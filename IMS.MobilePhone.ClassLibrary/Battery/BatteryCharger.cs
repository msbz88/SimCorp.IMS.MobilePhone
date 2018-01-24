using System;
using System.Threading;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Battery {
    public class BatteryCharger : IBatteryCharger {
        ManualResetEvent chargeEvent = new ManualResetEvent(false);
        Thread ChargeBatteryThread { get; set; }
        BatteryBase Battery { get; set; }

        public BatteryCharger(BatteryBase battery) {
            Battery = battery;
            ChargeBatteryThread = new Thread(() => ChargeBattery(battery)) ;
            ChargeBatteryThread.Start();
        }

        public void StartCharge() {
            Battery.StopDisCharging();
            chargeEvent.Set();
        }

        public void StopCharge() {
            chargeEvent.Reset();
            Battery.StartDisCharging();
        }

        public void ChargeBattery(BatteryBase battery) {
            while(battery.Capacity != battery.Charge) {
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
