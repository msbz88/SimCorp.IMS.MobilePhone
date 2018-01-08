using System;

namespace Simcorp.IMS.MobilePhone.Battery {
    public abstract class BatteryBase {
        private int volume;
        public int Volume {
            get { return volume; }
            private set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "BatteryBase.Volume"); }
                else { volume = value; }
            }
        }

        private int charge;
        public int Charge {
            get { return charge; }
            set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "BatteryBase.Charge"); }
                else if (value > Volume) { throw new ArgumentException($"Parameter cannot be greater than {this.Volume}.", "BatteryBase.Charge"); }
                else { charge = value; }
            }
        }

        public BatteryBase(int volume) {
            this.Volume = volume;
        }

        IBatteryCharger BatteryCharger { get; set; }

        public void ChargeBattery() {
            BatteryCharger.ChargeBattery(this);
        }

        public abstract double GetBatteryChargeLevel();
    }
}
