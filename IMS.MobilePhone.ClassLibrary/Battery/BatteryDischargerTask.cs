using System;
using System.Threading;
using System.Threading.Tasks;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Battery {
   public class BatteryDischargerTask {
        protected Task BatteryTask { get; set; }
        ManualResetEvent dischargeEvent = new ManualResetEvent(false);
        BatteryBase Battery { get; set; }

        public BatteryDischargerTask(BatteryBase battery) {
            Battery = battery;
            BatteryTask = new Task(BatteryDischarging);
            BatteryTask.Start();
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
