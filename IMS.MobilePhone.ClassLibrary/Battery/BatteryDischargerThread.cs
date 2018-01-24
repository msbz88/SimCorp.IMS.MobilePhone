using System;
using System.Threading;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Battery {
    public class BatteryDischargerThread {
        protected Thread BatteryThread { get; set; }
        ManualResetEvent dischargeEvent = new ManualResetEvent(false);
        BatteryBase Battery { get; set; }

        public BatteryDischargerThread(BatteryBase battery) {
            Battery = battery;
            BatteryThread = new Thread(BatteryDischarging);
            BatteryThread.Start();
        }

        public void StartDisCharging() {
            dischargeEvent.Set();
        }

        public void StopDisCharging() {
            dischargeEvent.Reset();
        }

        private void BatteryDischarging() {
            while (Battery.Charge >= 0) {
                dischargeEvent.WaitOne();
                lock (this) {
                    Thread.Sleep(5000);
                    try {
                        Battery.Charge -= 100;
                    }
                    catch (ArgumentException) {
                        Battery.Charge = 0;
                    }
                }
            }
        }
    }
}
