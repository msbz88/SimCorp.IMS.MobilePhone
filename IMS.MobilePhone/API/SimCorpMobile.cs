using Simcorp.IMS.MobilePhone.Screen;
using Simcorp.IMS.MobilePhone.Battery;
using Simcorp.IMS.MobilePhone.Audio;
using Simcorp.IMS.MobilePhone.Speaker;
using Simcorp.IMS.MobilePhone.Headset;

namespace Simcorp.IMS.MobilePhone.API {
    public class SimCorpMobile : Mobile {
        public override ScreenBase Screen { get { return vScreen; } }
        private readonly OLEDScreen vScreen = new OLEDScreen(5, 1920, 1080);
        public override BatteryBase Battery { get { return vBattery; } }
        private readonly LithiumLonBattery vBattery = new LithiumLonBattery(4000);
        public override PhoneSpeaker Speaker { get { return new PhoneSpeaker(1000); } }
        public override AudioController Audio { get; }
    }
}
