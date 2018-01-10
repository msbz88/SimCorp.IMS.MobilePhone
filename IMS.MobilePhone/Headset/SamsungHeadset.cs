using System;
using Simcorp.IMS.MobilePhone.Audio;
using Simcorp.IMS.MobilePhone.Output;

namespace Simcorp.IMS.MobilePhone.Headset {
    class SamsungHeadset : IAudioController {
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
