﻿using System;

namespace Simcorp.IMS.MobilePhone.Screen {
    public class MonochromeScreen : ScreenBase {
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
