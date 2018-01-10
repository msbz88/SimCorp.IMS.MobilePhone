using System;
using Simcorp.IMS.MobilePhone.Headset;

namespace Simcorp.IMS.MobilePhone.Audio {
    public class PhoneSpeaker : IPlayback {
        public AudioController AudioController = new AudioController(0);

        public PhoneSpeaker(int maxVolume) {
            this.AudioController.MaxVolume = maxVolume;
        }

        public override string ToString() {
            return $"Audio Type: Phone Speaker (Max volume: {AudioController.MaxVolume}, current volume: {AudioController.GetAudioVolumeLevel() * 100}%)";
        }

        public void Play() {
            Console.WriteLine(this);
        }
    }
}
