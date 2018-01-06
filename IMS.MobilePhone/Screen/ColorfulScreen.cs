using System;

namespace Simcorp.IMS.MobilePhone.Screen {
    public class ColorfulScreen : ScreenBase {
        public override void Show(IScreenImage screenImage) {
            Console.WriteLine($"I am {nameof(ColorfulScreen)}");
        }

        public override void Show(IScreenImage screenImage, int brightness) {
            Console.WriteLine($"I am {nameof(ColorfulScreen)}, my brightness is {brightness}");
        }

        public override string ToString() {
            return "Colorful Screen";
        }
    }
}
