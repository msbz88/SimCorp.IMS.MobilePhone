﻿using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Screen {
    public class OLEDScreen : ColorfulScreen {
        public OLEDScreen(int sizeInch, int heightPixel, int widthPixel) : base(sizeInch, heightPixel, widthPixel) {
        }

        public override void Show(IScreenImage screenImage) {
            Console.WriteLine($"I am {nameof(OLEDScreen)}");
        }

        public override void Show(IScreenImage screenImage, int brightness) {
            Console.WriteLine($"I am {nameof(OLEDScreen)}, my brightness is {brightness}");
        }

        public override string ToString() {
            return $"Screen Type: OLED Screen ({this.SizeInch}\", {this.HeightPixel}x{this.WidthPixel})";
        }
    }
}
