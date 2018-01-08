using System;

namespace Simcorp.IMS.MobilePhone.Dynamic {
    public abstract class DynamicBase {
        private int volume;
        public int Volume {
            get { return volume; }
            private set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "DynamicBase.Volume"); }
                else { volume = value; }
            }
        }

        private int currentVolume;
        public int CurrentVolume {
            get { return currentVolume; }
            set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "DynamicBase.CurrentVolume"); }
                else if (value > Volume) { throw new ArgumentException($"Parameter cannot be greater than {this.Volume}.", "DynamicBase.CurrentVolume"); }
                else { currentVolume = value; }
            }
        }

        private int currentVolumeStep;
        public int CurrentVolumeStep {
            get { return currentVolumeStep; }
            protected set {
                if (value < 0) { throw new ArgumentException("Parameter cannot be less than 0.", "BassDynamic.CurrentVolumeStep"); }
                else if (value > Volume) { throw new ArgumentException($"Parameter cannot be greater than {this.Volume}.", "BassDynamic.CurrentVolumeStep"); }
                else { currentVolumeStep = value; }
            }
        }

        public DynamicBase(int volume) {
            this.Volume = volume;
        }

        public abstract double GetDynamicVolumeLevel();

        public abstract void IncreaseDynamicVolumeLevel();

        public abstract void DecreaseDynamicVolumeLevel();
    }
}
