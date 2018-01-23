using System;
using System.Threading;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Battery {
    public abstract class BatteryBase {
        public delegate void ChargeNotification();
        public static event ChargeNotification OnChargeChanged;
        public static Object LockCharge = new Object();
        Thread BatteryThread { get; set; }

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
            BatteryThread = new Thread(DischargeBattery);
            BatteryThread.Start();
        }

        IBatteryCharger BatteryCharger { get; set; }

        public void ChargeBattery() {
            BatteryCharger.ChargeBattery(this);
        }

        private void DischargeBattery() {
            lock (LockCharge) {
                while (Charge > 0) {
                    lock (LockCharge) {
                        try {
                            Charge -= 100;
                        }
                        catch (ArgumentException) {
                            Charge = 0;
                        }
                        Thread.Sleep(5000);
                    }
                }
            }
        }

        public abstract double GetBatteryChargeLevel();
    }
}
