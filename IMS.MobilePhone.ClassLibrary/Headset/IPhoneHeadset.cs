using Simcorp.IMS.MobilePhone.ClassLibrary.Audio;
using Simcorp.IMS.MobilePhone.ClassLibrary.API;
using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Headset {
    public class IPhoneHeadset : IAudioController {
        private IOutput Output;

        public AudioController AudioController { get; set; }

        public IPhoneHeadset(int maxVolume) {
            AudioController = new AudioController(maxVolume);
        }

        public IPhoneHeadset(IOutput output) {
            this.Output = output;
        }

        public override string ToString() {
            return $"Audio Type: IPhone Headset (Max volume: {AudioController.MaxVolume}, current volume: {AudioController.GetAudioVolumeLevel() * 100}%)";
        }

        public void Play() {
            Console.WriteLine(this);
        }
    }
}