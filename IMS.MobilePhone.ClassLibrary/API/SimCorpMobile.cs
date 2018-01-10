using Simcorp.IMS.MobilePhone.ClassLibrary.Battery;
using Simcorp.IMS.MobilePhone.ClassLibrary.Screen;
using Simcorp.IMS.MobilePhone.ClassLibrary.Speaker;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.API {
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
