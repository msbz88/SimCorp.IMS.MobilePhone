using Simcorp.IMS.MobilePhone.ClassLibrary.Audio;
using Simcorp.IMS.MobilePhone.ClassLibrary.API;
using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Headset {
   public class SamsungHeadset : IAudioController {
        private IOutput Output;

        public AudioController AudioController { get; set; }

        public SamsungHeadset(int maxVolume) {
            AudioController = new AudioController(maxVolume);
        }

        public SamsungHeadset(IOutput output) {
            this.Output = output;
        }

        public override string ToString() {
            return $"Audio Type: Samsung Headset (Max volume: {AudioController.MaxVolume}, current volume: {AudioController.GetAudioVolumeLevel() * 100}%)";
        }

        public void Play() {
            Console.WriteLine(this);
        }
    }
}
