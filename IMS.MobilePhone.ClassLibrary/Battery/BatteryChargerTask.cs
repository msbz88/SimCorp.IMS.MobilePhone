using System;
using System.Threading;
using System.Threading.Tasks;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Battery {
    public class BatteryChargerTask : ChargeBase, IBatteryCharger {
        ManualResetEvent chargeEvent = new ManualResetEvent(false);
        Task ChargeBatteryThread { get; set; }
        BatteryBase Battery { get; set; }
        BatteryDischargerTask BatteryDischarger { get; set; }

        public BatteryChargerTask(BatteryBase battery) {
            Battery = battery;
            ChargeBatteryThread = new Task(() => ChargeBattery(battery));
            ChargeBatteryThread.Start();
            BatteryDischarger = new BatteryDischargerTask(battery);
        }

        public override void StartCharge() {
            BatteryDischarger.StopDisCharging();
            chargeEvent.Set();
        }

        public override void StopCharge() {
            chargeEvent.Reset();
            BatteryDischarger.StartDisCharging();
        }

        public void ChargeBattery(BatteryBase battery) {
            while (battery.Capacity != battery.Charge) {
                chargeEvent.WaitOne();
                lock (battery) {
                    try {
                        battery.Charge += 100;
                    }
                    catch (ArgumentException) {
                        battery.Charge += battery.Capacity - battery.Charge;
                    }
                    Thread.Sleep(2000);
                }
            }
            StopCharge();
        }
    }
}
