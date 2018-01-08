using System;

namespace Simcorp.IMS.MobilePhone.Screen {
    public class RetinaScreen : ColorfulScreen {
        public RetinaScreen(int sizeInch, int heightPixel, int widthPixel) : base(sizeInch, heightPixel, widthPixel) {
        }

        public override void Show(IScreenImage screenImage) {
            Console.WriteLine($"I am {nameof(RetinaScreen)}");
        }

        public override void Show(IScreenImage screenImage, int brightness) {
            Console.WriteLine($"I am {nameof(RetinaScreen)}, my brightness is {brightness}");
        }

        public override string ToString() {
            return $"Retina Screen ({this.SizeInch}\", {this.HeightPixel}x{this.WidthPixel})";
        }
    }
}
