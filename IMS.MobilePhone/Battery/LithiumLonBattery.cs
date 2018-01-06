using System;

namespace Simcorp.IMS.MobilePhone.Battery {
    class LithiumLonBattery: BatteryBase {
        public LithiumLonBattery(int volume, int charge) {
            this.Volume = volume;
            this.Charge = charge;
        }

        public override void GetStatus(IBattery battery) {
            Console.WriteLine($"I am {nameof(LithiumLonBattery)}");
        }

        public override void GetStatus(IBattery battery, int volume) {
            Console.WriteLine($"I am {nameof(LithiumLonBattery)}, my volume is {volume}");
        }

        public override void GetStatus(IBattery battery, int volume, int charge) {
            Console.WriteLine($"I am {nameof(LithiumLonBattery)}, my volume is {volume} and my charge is {charge}");
        }

        public override string ToString() {
            return $"Lithium Lon Battery (volume: {this.Volume}, charged: {this.Charge}%)";
        }

    }
}
