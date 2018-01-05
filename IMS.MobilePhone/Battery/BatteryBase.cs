using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.IMS.MobilePhone {
    public abstract class BatteryBase: IBattery {
        public int Charge {
            get { return Charge; }
            set {
                if (Charge < 0) { Charge = 0; }
                else if (Charge > 100) { Charge = 100; }
                else { Charge = value; }
            }
        }

        public int Volume {
            get { return Volume; }
            set {
                if (Volume < 0) { Volume = 0; }
                else { Volume = value; }
            }
        }

        public abstract void GetStatus(IBattery battery);

        public abstract void GetStatus(IBattery battery, int volume);

        public abstract void GetStatus(IBattery battery, int volume, int charge);
    }
}
