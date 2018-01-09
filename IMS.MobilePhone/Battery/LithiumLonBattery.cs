using System;

namespace Simcorp.IMS.MobilePhone.Battery {
    class LithiumLonBattery: BatteryBase {
        public LithiumLonBattery(int volume) : base(volume) {
        }

        public override double GetBatteryChargeLevel() {
            if (this.Charge != 0 && this.Volume != 0) {
                return (double)this.Charge / (double)this.Volume;
            }
            else { return 0; }
        }

        public override string ToString() {
            return $"Lithium Lon Battery (volume: {this.Volume}, charged: {GetBatteryChargeLevel() * 100}%)";
        }

    }
}
