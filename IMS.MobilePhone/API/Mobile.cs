using System.Text;
using Simcorp.IMS.MobilePhone.Screen;
using Simcorp.IMS.MobilePhone.Battery;
using Simcorp.IMS.MobilePhone.Dynamic;

namespace Simcorp.IMS.MobilePhone.API {
    public abstract class Mobile {
        public abstract ScreenBase Screen { get; }
        public abstract BatteryBase Battery { get; }
        public abstract DynamicBase Dynamic { get; }

        private void Show(IScreenImage screenImage) {
            Screen.Show(screenImage);
        }

        private void Show(IScreenImage screenImage, int brightness) {
            Screen.Show(screenImage, brightness);
        }

        private double GetBatteryChargeLevel() {
            return Battery.GetBatteryChargeLevel();
        }

        private void ChargeBattery() {
            Battery.ChargeBattery();
        }

        private double GetDynamicVolumeLevel() {
            return Dynamic.GetDynamicVolumeLevel();
        }

        private void IncreaseDynamicVolumeLevel() {
            Dynamic.IncreaseDynamicVolumeLevel();
        }

        private void DecreaseDynamicVolumeLevel() {
            Dynamic.DecreaseDynamicVolumeLevel();
        }

        public string Description() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Battery Type: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Dynamic Type: {Dynamic.ToString()}");
            return descriptionBuilder.ToString();
        }
    }
}
