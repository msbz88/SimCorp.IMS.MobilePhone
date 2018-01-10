using System;
using Simcorp.IMS.MobilePhone.Audio;

namespace Simcorp.IMS.MobilePhone.Speaker {
    public class PhoneSpeaker : IAudioController {
        public AudioController AudioController { get; set; }

        public PhoneSpeaker(int maxVolume) {
            AudioController = new AudioController(maxVolume);
        }

        public override string ToString() {
            return $"Audio Type: Phone Speaker (Max volume: {AudioController.MaxVolume}, current volume: {AudioController.GetAudioVolumeLevel() * 100}%)";
        }

        public void Play() {
            Console.WriteLine(this);
        }
    }
}
