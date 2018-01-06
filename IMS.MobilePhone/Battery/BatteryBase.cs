namespace Simcorp.IMS.MobilePhone.Battery {
    public abstract class BatteryBase {
        private int volume;
        protected int Volume {
            get { return volume; }
            set {
                if (value < 0) { volume = 0; }
                else { volume = value; }
            }
        }

        private int charge;
        protected int Charge {
            get { return charge; }
            set {
                if (value < 0) { charge = 0; }
                else if (value > 100) { charge = 100; }
                else { charge = value; }
            }
        }

        public abstract void GetStatus(IBattery battery);

        public abstract void GetStatus(IBattery battery, int volume);

        public abstract void GetStatus(IBattery battery, int volume, int charge);
    }
}
