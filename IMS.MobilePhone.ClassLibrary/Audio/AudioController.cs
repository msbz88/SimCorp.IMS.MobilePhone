using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Audio {
    public class AudioController {
        private int maxVolume;
        public int MaxVolume {
            get { return maxVolume; }
            set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "AudioControllerBase.MaxVolume"); }
                else { maxVolume = value; }
            }
        }

        private int currentVolume;
        public int CurrentVolume {
            get { return currentVolume; }
            set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "AudioControllerBase.CurrentVolume"); }
                else if (value > MaxVolume) { throw new ArgumentException($"Parameter cannot be greater than {this.MaxVolume}.", "AudioControllerBase.CurrentVolume"); }
                else { currentVolume = value; }
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
            } else { Console.WriteLine($"Cannot raise Phone Speaker maxVolume on {currentVolumeStep}, because it will be more then maximum.\n"); }
        }

        public void DecreaseAudioVolumeLevel(int currentVolumeStep) {
            if (this.CurrentVolume >= currentVolumeStep) {
                this.CurrentVolume -= currentVolumeStep;
            } else { Console.WriteLine($"Cannot reduce Phone Speaker maxVolume on {currentVolumeStep}, because it will be less then 0.\n"); }
        }

        IAudioController AudioComponent { get; set; }

        public void Play() {
            AudioComponent.Play();
        }
    }
}
