using Simcorp.IMS.MobilePhone.ClassLibrary.Audio;
using Simcorp.IMS.MobilePhone.ClassLibrary.Output;
using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Headset {
   public class SamsungHeadset : IAudioController {
        private IOutput Output;

        public AudioController AudioController { get; set; }

        public SamsungHeadset(int maxVolume, IOutput output) {
            AudioController = new AudioController(maxVolume);
            this.Output = output;
        }

        public override string ToString() {
            return $"Audio Type: Samsung Headset (Max volume: {AudioController.MaxVolume}, current volume: {AudioController.GetAudioVolumeLevel() * 100}%)";
        }

        public void Play() {
            Output.WriteLine(ToString());
        }
    }
}
