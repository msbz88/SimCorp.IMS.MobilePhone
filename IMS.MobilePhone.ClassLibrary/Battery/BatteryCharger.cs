using System;
using System.Threading;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Battery {
    public class BatteryCharger : IBatteryCharger {
        Thread ChargeBatteryThread { get; set; }
        BatteryBase Battery { get; set; }
        private static bool IsCharging { get; set; }

        public BatteryCharger(BatteryBase battery) {
            Battery = battery;
            IsCharging = false;
        }

        private void Charge() {
            ChargeBattery(Battery);
        }

        public void StartCharge() {
            IsCharging = true;
            ChargeBatteryThread = new Thread(Charge);
            ChargeBatteryThread.Start();
        }

        public void StopCharge() {
            IsCharging = false;
        }

        public void ChargeBattery(BatteryBase battery) {
            while(battery.Capacity != battery.Charge && IsCharging) {
                lock (BatteryBase.LockCharge) {
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
