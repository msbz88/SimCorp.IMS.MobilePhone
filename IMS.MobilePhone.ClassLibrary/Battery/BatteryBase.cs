using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Battery {
    public abstract class BatteryBase {
        private int capacity;
        public int Capacity {
            get { return capacity; }
            set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "BatteryBase.Capacity"); }
                else { capacity = value; }
            }
        }

        private int charge;
        public int Charge {
            get { return charge; }
            set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "BatteryBase.Charge"); }
                else if (value > Capacity) { throw new ArgumentException($"Parameter cannot be greater than {this.Capacity}.", "BatteryBase.Charge"); }
                else { charge = value; }
            }
        }

        public BatteryBase(int capacity) {
            this.Capacity = capacity;
        }

        IBatteryCharger BatteryCharger { get; set; }

        public void ChargeBattery() {
            BatteryCharger.ChargeBattery(this);
        }

        public abstract double GetBatteryChargeLevel();
    }
}
