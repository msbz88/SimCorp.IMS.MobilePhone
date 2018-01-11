using Simcorp.IMS.MobilePhone.ClassLibrary.Audio;
using Simcorp.IMS.MobilePhone.ClassLibrary.Output;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Headset {
    public class IPhoneHeadset : IAudioController {
        private IOutput Output;

        public AudioController AudioController { get; set; }

        public IPhoneHeadset(int maxVolume, IOutput output) {
            AudioController = new AudioController(maxVolume);
            this.Output = output;
        }

        public override string ToString() {
            return $"Audio Type: IPhone Headset (Max volume: {AudioController.MaxVolume}, current volume: {AudioController.GetAudioVolumeLevel() * 100}%)";
        }

        public void Play() {
            Output.WriteLine(ToString());
        }
    }
}