using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Screen {
    public class MonochromeScreen : ScreenBase {
        public MonochromeScreen(int sizeInch, int heightPixel, int widthPixel) : base(sizeInch, heightPixel, widthPixel) {
        }

        public override void Show(IScreenImage screenImage) {
            Console.WriteLine($"I am {nameof(MonochromeScreen)}");
        }

        public override void Show(IScreenImage screenImage, int brightness) {
            Console.WriteLine($"I am {nameof(MonochromeScreen)}, my brightness is {brightness}");
        }

        public override string ToString() {
            return "Monochrome Screen";
        }
    }
}
