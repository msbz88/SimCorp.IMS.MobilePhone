using System;
using Simcorp.IMS.MobilePhone.Audio;

namespace Simcorp.IMS.MobilePhone.Headset {
    class SamsungHeadset : IAudioController {
        public AudioController AudioController { get; set; }

        public SamsungHeadset(int maxVolume) {
            AudioController = new AudioController(maxVolume);
        }

        public override string ToString() {
            return $"Audio Type: Samsung Headset (Max volume: {AudioController.MaxVolume}, current volume: {AudioController.GetAudioVolumeLevel() * 100}%)";
        }

        public void Play() {
            Console.WriteLine(this);
        }
    }
}
