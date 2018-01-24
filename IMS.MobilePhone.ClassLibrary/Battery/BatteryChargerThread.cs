using System;
using System.Threading;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Battery {
    public class BatteryChargerThread : ChargeBase, IBatteryCharger {
        ManualResetEvent chargeEvent = new ManualResetEvent(false);
        Thread ChargeBatteryThread { get; set; }
        BatteryBase Battery { get; set; }
        BatteryDischargerThread BatteryDischarger { get; set; }

        public BatteryChargerThread(BatteryBase battery) {
            Battery = battery;
            ChargeBatteryThread = new Thread(() => ChargeBattery(battery)) ;
            ChargeBatteryThread.Start();
            BatteryDischarger = new BatteryDischargerThread(battery);
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
            while (true) {
                chargeEvent.WaitOne();
                lock (battery) {
                    try {
                        battery.Charge += 100;
                    }
                    catch (ArgumentException) {
                        battery.Charge += battery.Capacity - battery.Charge;
                        StopCharge();
                    }
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
