using Simcorp.IMS.MobilePhone.ClassLibrary.Audio;
using Simcorp.IMS.MobilePhone.ClassLibrary.Output;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Speaker {
    public class PhoneSpeaker : IAudioController {
        private IOutput Output;

        public AudioController AudioController { get; set; }

        public PhoneSpeaker(int maxVolume, IOutput output) {
            AudioController = new AudioController(maxVolume);
            this.Output = output;
        }

        public override string ToString() {
            return $"Audio Type: Phone Speaker (Max volume: {AudioController.MaxVolume}, current volume: {AudioController.GetAudioVolumeLevel() * 100}%)";
        }

        public void Play() {
            Output.WriteLine(ToString());
        }
    }
}
