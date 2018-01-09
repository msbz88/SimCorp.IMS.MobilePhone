using System;
using Simcorp.IMS.MobilePhone.Headset;

namespace Simcorp.IMS.MobilePhone.Speaker {
    public abstract class SpeakerBase : IPlayback {
        private int volume;
        public int Volume {
            get { return volume; }
            private set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "SpeakerBase.Volume"); }
                else { volume = value; }
            }
        }

        private int currentVolume;
        public int CurrentVolume {
            get { return currentVolume; }
            set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "SpeakerBase.CurrentVolume"); }
                else if (value > Volume) { throw new ArgumentException($"Parameter cannot be greater than {this.Volume}.", "SpeakerBase.CurrentVolume"); }
                else { currentVolume = value; }
            }
        }

        public SpeakerBase(int volume) {
            this.Volume = volume;
        }

        public abstract double GetSpeakerVolumeLevel();

        public abstract void IncreaseSpeakerVolumeLevel(int currentVolumeStep);

        public abstract void DecreaseSpeakerVolumeLevel(int currentVolumeStep);

        public abstract void Play(object data);
    }
}
