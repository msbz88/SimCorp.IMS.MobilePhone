using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Screen {
    public abstract class ScreenBase {
        private int vSizeInch;
        public int SizeInch {
            get { return vSizeInch; }
            private set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "ScreenBase.SizeInch"); }
                else { vSizeInch = value; }
            }
        }

        private int vHeightPixel;
        public int HeightPixel {
            get { return vHeightPixel; }
            private set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "ScreenBase.HeightPixel"); }
                else { vHeightPixel = value; }
            }
        }

        private int vWidthPixel;
        public int WidthPixel {
            get { return vWidthPixel; }
            private set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "ScreenBase.WidthPixel"); }
                else { vWidthPixel = value; }
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
