using Simcorp.IMS.MobilePhone.Battery;
using Simcorp.IMS.MobilePhone.Screen;
using Simcorp.IMS.MobilePhone.Speaker;

namespace Simcorp.IMS.MobilePhone.API {
    public class SimCorpMobile : Mobile {
        public override ScreenBase Screen { get; }
        public override BatteryBase Battery { get; }
        public override PhoneSpeaker Speaker { get; }

        public SimCorpMobile(ScreenBase screen, BatteryBase battery, PhoneSpeaker speaker) {
            this.Screen = screen;
            this.Battery = battery;
            this.Speaker = speaker;
        }
    }
}
