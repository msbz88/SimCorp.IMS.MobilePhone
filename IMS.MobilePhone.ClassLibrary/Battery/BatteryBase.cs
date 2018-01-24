using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Battery {
    public abstract class BatteryBase {
        public delegate void ChargeNotification();
        public static event ChargeNotification OnChargeChanged;
        public static event ChargeNotification OnChargeLess10;
        public static event ChargeNotification OnChargeZero;
        IBatteryCharger BatteryCharger { get; set; }

        private int vCapacity;
        public int Capacity {
            get { return vCapacity; }
            set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "BatteryBase.Capacity"); }
                else { vCapacity = value; }
            }
        }

        private int vCharge;
        public int Charge {
            get { return vCharge; }
            set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "BatteryBase.Charge"); }
                else if (value > Capacity) { throw new ArgumentException($"Parameter cannot be greater than {this.Capacity}.", "BatteryBase.Charge"); }
                else {
                    vCharge = value;
                    OnChargeChanged?.Invoke();
                }
                if (GetBatteryChargeLevel() * 100 == 10) { OnChargeLess10?.Invoke(); }
                if (vCharge == 0) { OnChargeZero?.Invoke(); }
            }
        }

        public BatteryBase(int capacity) {
            this.Capacity = capacity;
            if (Charge == 0) { OnChargeZero?.Invoke(); }
        }

        public void ChargeBattery() {
            BatteryCharger.ChargeBattery(this);
        }

        public abstract double GetBatteryChargeLevel();
    }
}
