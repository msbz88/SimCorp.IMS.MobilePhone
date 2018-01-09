using System.Text;
using Simcorp.IMS.MobilePhone.Screen;
using Simcorp.IMS.MobilePhone.Battery;
using Simcorp.IMS.MobilePhone.Speaker;
using Simcorp.IMS.MobilePhone.Headset;

namespace Simcorp.IMS.MobilePhone.API {
    public abstract class Mobile {
        public abstract ScreenBase Screen { get; }
        public abstract BatteryBase Battery { get; }
        public abstract SpeakerBase Speaker { get; }
        public IPlayback PlaybackComponent { get; set; }

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

        private double GetSpeakerVolumeLevel() {
            return Speaker.GetSpeakerVolumeLevel();
        }

        private void IncreaseSpeakerVolumeLevel(int currentVolumeStep) {
            Speaker.IncreaseSpeakerVolumeLevel(currentVolumeStep);
        }

        private void DecreaseSpeakerVolumeLevel(int currentVolumeStep) {
            Speaker.DecreaseSpeakerVolumeLevel(currentVolumeStep);
        }

        public void Play(object data) {
            PlaybackComponent.Play(data);
        }
    }
}
