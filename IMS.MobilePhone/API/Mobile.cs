using System.Text;
using Simcorp.IMS.MobilePhone.Screen;
using Simcorp.IMS.MobilePhone.Battery;

namespace Simcorp.IMS.MobilePhone.API {
    public abstract class Mobile {
        public abstract ScreenBase Screen { get; }
        public abstract BatteryBase Battery { get; }

        private void Show(IScreenImage screenImage) {
            Screen.Show(screenImage);
        }

        private void Show(IScreenImage screenImage, int brightness) {
            Screen.Show(screenImage, brightness);
        }

        private void GetBatteryInfo() {
            Battery.GetBatteryInfo();
        }

        private void ChargeBattery() {
            Battery.ChargeBattery();
        }

        public string Description() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Battery Type: {Battery.ToString()}");
            return descriptionBuilder.ToString();
        }
    }
}
