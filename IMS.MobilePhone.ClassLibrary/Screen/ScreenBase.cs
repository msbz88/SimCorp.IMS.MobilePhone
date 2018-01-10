using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Screen {
    public abstract class ScreenBase {
        private int sizeInch;
        public int SizeInch {
            get { return sizeInch; }
            private set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "ScreenBase.SizeInch"); }
                else { sizeInch = value; }
            }
        }

        private int heightPixel;
        public int HeightPixel {
            get { return heightPixel; }
            private set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "ScreenBase.HeightPixel"); }
                else { heightPixel = value; }
            }
        }

        private int widthPixel;
        public int WidthPixel {
            get { return widthPixel; }
            private set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "ScreenBase.WidthPixel"); }
                else { widthPixel = value; }
            }
        }

        public ScreenBase(int sizeInch, int heightPixel, int widthPixel) {
            this.SizeInch = sizeInch;
            this.HeightPixel = heightPixel;
            this.WidthPixel = widthPixel;
        }

        public abstract void Show(IScreenImage screenImage);

        public abstract void Show(IScreenImage screenImage, int brightness);
    } 
}
