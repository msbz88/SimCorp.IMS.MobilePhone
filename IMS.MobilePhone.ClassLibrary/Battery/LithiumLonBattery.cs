﻿namespace Simcorp.IMS.MobilePhone.ClassLibrary.Battery {
    public class LithiumLonBattery: BatteryBase {
        public LithiumLonBattery(int capacity) : base(capacity) {
        }

        public override double GetBatteryChargeLevel() {
            if (this.Charge != 0 && this.Capacity != 0) {
                return (double)this.Charge / (double)this.Capacity;
            } else { return 0; }
        }

        public override string ToString() {
            return $"Battery Type: Lithium Lon Battery (Capacity: {this.Capacity}, charged: {GetBatteryChargeLevel() * 100}%)";
        }
    }
}
