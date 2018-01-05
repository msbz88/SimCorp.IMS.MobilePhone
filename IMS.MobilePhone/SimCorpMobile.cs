using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.IMS.MobilePhone{
    public class SimCorpMobile: Mobile{
        public override ScreenBase Screen { get { return vOLEDScreen; } }
        private readonly OLEDScreen vOLEDScreen = new OLEDScreen();
        public override BatteryBase Battery { get { return vLithiumLonBattery; } }
        private readonly LithiumLonBattery vLithiumLonBattery = new LithiumLonBattery();
    }
}
