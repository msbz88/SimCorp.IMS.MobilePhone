using Simcorp.IMS.MobilePhone.Screen;
using Simcorp.IMS.MobilePhone.Battery;
using Simcorp.IMS.MobilePhone.Dynamic;

namespace Simcorp.IMS.MobilePhone.API {
    public class SimCorpMobile : Mobile {
        public override ScreenBase Screen { get { return vOLEDScreen; } }
        private readonly OLEDScreen vOLEDScreen = new OLEDScreen(5, 1920, 1080);
        public override BatteryBase Battery { get { return vLithiumLonBattery; } }
        private readonly LithiumLonBattery vLithiumLonBattery = new LithiumLonBattery(4000);
        public override DynamicBase Dynamic { get { return vBassDynamic; } }
        private readonly LowFrequencyDynamic vBassDynamic = new LowFrequencyDynamic(500);
    }
}
