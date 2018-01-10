using Simcorp.IMS.MobilePhone.ClassLibrary.Audio;
using Simcorp.IMS.MobilePhone.ClassLibrary.Battery;
using Simcorp.IMS.MobilePhone.ClassLibrary.Screen;
using Simcorp.IMS.MobilePhone.ClassLibrary.Speaker;
using System;
using System.Text;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.API {
    public abstract class Mobile {
        public abstract ScreenBase Screen { get; }
        public abstract BatteryBase Battery { get; }
        public abstract PhoneSpeaker Speaker { get; }
        private AudioController Audio { get; }

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

        private double GetAudioVolumeLevel() {
            return Audio.GetAudioVolumeLevel();
        }

        private void IncreaseAudioVolumeLevel(int currentVolumeStep) {
            Audio.IncreaseAudioVolumeLevel(currentVolumeStep);
        }

        private void DecreaseAudioVolumeLevel(int currentVolumeStep) {
            Audio.DecreaseAudioVolumeLevel(currentVolumeStep);
        }

        public void Play() {
            Speaker.Play();
        }

        public void Play(IAudioController playbackComponent) {
            Console.WriteLine("Establishing connection with playback...");
            playbackComponent.Play();
        }

        public override string ToString() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine(Screen.ToString());
            descriptionBuilder.AppendLine(Battery.ToString());
            descriptionBuilder.AppendLine(Speaker.ToString());
            return descriptionBuilder.ToString();
        }
    }
}
