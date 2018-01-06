namespace Simcorp.IMS.MobilePhone.Screen {
    public abstract class ScreenBase {
        private int sizeInch;
        protected int SizeInch {
            get { return sizeInch; }
            set {
                if (value < 0) { sizeInch = 0; }
                else { sizeInch = value; }
            }
        }

        private int heightPixel;
        protected int HeightPixel {
            get { return heightPixel; }
            set {
                if (value < 0) { heightPixel = 0; }
                else { heightPixel = value; }
            }
        }

        private int widthPixel;
        protected int WidthPixel {
            get { return widthPixel; }
            set {
                if (value < 0) { widthPixel = 0; }
                else { widthPixel = value; }
            }
        }

        public abstract void Show(IScreenImage screenImage);

        public abstract void Show(IScreenImage screenImage, int brightness);
    } 
}
