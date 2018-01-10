using System;
using Simcorp.IMS.MobilePhone.Audio;

namespace Simcorp.IMS.MobilePhone.Headset {
    class IPhoneHeadset : IPlayback {
        public AudioController AudioController = new AudioController(0);

        public IPhoneHeadset(int maxVolume) {
            this.AudioController.MaxVolume = maxVolume;
        }

        public override string ToString() {
            return $"Audio Type: IPhone Headset (Max volume: {AudioController.MaxVolume}, current volume: {AudioController.GetAudioVolumeLevel() * 100}%)";
        }

        public void Play() {
            Console.WriteLine(this);
        }
    }
}