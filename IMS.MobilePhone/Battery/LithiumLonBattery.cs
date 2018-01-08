using System;
using System.Timers;

namespace Simcorp.IMS.MobilePhone.Battery {
    class LithiumLonBattery: BatteryBase {
        public LithiumLonBattery(int volume) : base(volume) {
        }

        public override void GetBatteryInfo() {
            Console.WriteLine($"I am {nameof(LithiumLonBattery)}, volume: {this.Volume}, charged: { this.Charge}");
        }

        public override string ToString() {
            return $"Lithium Lon Battery (volume: {this.Volume}, charged: {this.Charge}%)";
        }

    }
}
