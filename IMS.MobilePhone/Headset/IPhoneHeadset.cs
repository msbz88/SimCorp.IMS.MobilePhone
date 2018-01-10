using System;
using Simcorp.IMS.MobilePhone.Audio;

namespace Simcorp.IMS.MobilePhone.Headset {
    class IPhoneHeadset : IAudioController {
        public AudioController AudioController { get; set; }

        public IPhoneHeadset(int maxVolume) {
            AudioController = new AudioController(maxVolume);
        }

        public override string ToString() {
            return $"Audio Type: IPhone Headset (Max volume: {AudioController.MaxVolume}, current volume: {AudioController.GetAudioVolumeLevel() * 100}%)";
        }

        public void Play() {
            Console.WriteLine(this);
        }
    }
}