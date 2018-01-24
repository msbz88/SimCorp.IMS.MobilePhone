using System;
using System.Threading;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Battery {
    public abstract class BatteryBase {
        public delegate void ChargeNotification();
        public static event ChargeNotification OnChargeChanged;
        protected Thread BatteryThread { get; set; }
        ManualResetEvent dischargeEvent = new ManualResetEvent(false);
        IBatteryCharger BatteryCharger { get; set; }

        private int vCapacity;
        public int Capacity {
            get { return vCapacity; }
            set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "BatteryBase.Capacity"); }
                else { vCapacity = value; }
            }
        }

        private int vCharge;
        public int Charge {
            get { return vCharge; }
            set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "BatteryBase.Charge"); }
                else if (value > Capacity) { throw new ArgumentException($"Parameter cannot be greater than {this.Capacity}.", "BatteryBase.Charge"); }
                else {
                    vCharge = value;
                    OnChargeChanged?.Invoke();
                }
            }
        }

        public BatteryBase(int capacity) {
            this.Capacity = capacity;
            BatteryThread = new Thread(BatteryDischarging);
            BatteryThread.Start();
        }

        public void ChargeBattery() {
            BatteryCharger.ChargeBattery(this);
        }

        public void StartDisCharging() {
            dischargeEvent.Set();
        }

        public void StopDisCharging() {
            dischargeEvent.Reset();
        }

        protected void BatteryDischarging() {
            while (Charge >= 0) {
                dischargeEvent.WaitOne();
                lock (this) {
                    Thread.Sleep(5000);
                    try {
                        Charge -= 100;
                    }
                    catch (ArgumentException) {
                        Charge = 0;
                    }
                }
            }         
        }

        public abstract double GetBatteryChargeLevel();
    }
}
