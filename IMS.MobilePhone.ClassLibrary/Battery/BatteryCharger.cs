using System;
using System.Threading;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Battery {
    public class BatteryCharger : IBatteryCharger {
        Thread ChargeBatteryThread { get; set; }
        BatteryBase Battery { get; set; }

        public BatteryCharger(BatteryBase battery) {
            Battery = battery;
            battery.IsCharging = false;
        }

        public void StartCharge() {
            Battery.IsCharging = true;
            ChargeBatteryThread = new Thread(Charge);
            ChargeBatteryThread.Start();
        }

        private void Charge() {
            ChargeBattery(Battery);
        }

        public void StopCharge() {
            Battery.IsCharging = false;
            Battery.StartDischarge();
        }

        public void ChargeBattery(BatteryBase battery) {
            while(battery.Capacity != battery.Charge && Battery.IsCharging) {
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
        }
    }
}
