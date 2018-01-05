using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.IMS.MobilePhone {
    class LithiumLonBattery: BatteryBase {
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
            return "Lithium Lon Battery";
        }

    }
}
