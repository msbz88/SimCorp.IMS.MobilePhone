using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.IMS.MobilePhone {
    public abstract class Mobile {
        public abstract ScreenBase Screen { get; }
        public abstract BatteryBase Battery { get; }

        private void Show(IScreenImage screenImage) {
            Screen.Show(screenImage);
        }

        private void Show(IScreenImage screenImage, int brightness) {
            Screen.Show(screenImage, brightness);
        }

        private void GetStatus(IBattery battery) {
            Battery.GetStatus(battery);
        }

        private void GetStatus(IBattery battery, int volume) {
            Battery.GetStatus(battery, volume);
        }

        private void GetStatus(IBattery battery, int volume, int charge) {
            Battery.GetStatus(battery, volume, charge);
        }

        public string Description() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}\nBattery Type: {Battery.ToString()}");
            return descriptionBuilder.ToString();
        }
    }
}
