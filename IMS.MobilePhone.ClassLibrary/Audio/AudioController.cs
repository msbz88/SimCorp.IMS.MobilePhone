using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Audio {
    public class AudioController {
        private int vMaxVolume;
        public int MaxVolume {
            get { return vMaxVolume; }
            set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "AudioControllerBase.MaxVolume"); }
                else { vMaxVolume = value; }
            }
        }

        private int vCurrentVolume;
        public int CurrentVolume {
            get { return vCurrentVolume; }
            set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "AudioControllerBase.CurrentVolume"); }
                else if (value > MaxVolume) { throw new ArgumentException($"Parameter cannot be greater than {this.MaxVolume}.", "AudioControllerBase.CurrentVolume"); }
                else { vCurrentVolume = value; }
            }
        }

        public AudioController(int maxVolume) {
            this.MaxVolume = maxVolume;
        }

        public double GetAudioVolumeLevel() {
            if (this.CurrentVolume != 0 && this.MaxVolume != 0) {
                return (double)this.CurrentVolume / (double)this.MaxVolume;
            } else { return 0; }
        }

        public void IncreaseAudioVolumeLevel(int currentVolumeStep) {
            if (this.MaxVolume - this.CurrentVolume >= currentVolumeStep) {
                this.CurrentVolume += currentVolumeStep;
            } else { Console.WriteLine($"Cannot raise Phone Speaker vMaxVolume on {currentVolumeStep}, because it will be more then maximum.\n"); }
        }

        public void DecreaseAudioVolumeLevel(int currentVolumeStep) {
            if (this.CurrentVolume >= currentVolumeStep) {
                this.CurrentVolume -= currentVolumeStep;
            } else { Console.WriteLine($"Cannot reduce Phone Speaker vMaxVolume on {currentVolumeStep}, because it will be less then 0.\n"); }
        }

        IAudioController AudioComponent { get; set; }

        public void Play() {
            AudioComponent.Play();
        }
    }
}
