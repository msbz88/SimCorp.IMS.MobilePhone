using System;

namespace Simcorp.IMS.MobilePhone.Dynamic {
    class LowFrequencyDynamic : DynamicBase {
        public LowFrequencyDynamic(int volume) : base(volume) {
        }

        public override double GetDynamicVolumeLevel() {
            if (this.CurrentVolume != 0 && this.Volume != 0) {
                return (double)this.CurrentVolume / (double)this.Volume;
            }
            else { return 0; }
        }

        public override void IncreaseDynamicVolumeLevel(int currentVolumeStep) {
            if (this.Volume - this.CurrentVolume >= currentVolumeStep) {
                this.CurrentVolume += currentVolumeStep;
            }
            else { Console.WriteLine($"Cannot raise Bass Dynamic volume on {currentVolumeStep}, because volume will be more then maximum.\n"); }
        }

        public override void DecreaseDynamicVolumeLevel(int currentVolumeStep) {
            if (this.CurrentVolume >= currentVolumeStep) {
                this.CurrentVolume -= currentVolumeStep;
            }
            else { Console.WriteLine($"Cannot reduce Bass Dynamic volume on {currentVolumeStep}, because volume will be less then 0.\n"); }
        }

        public override string ToString() {
            return $"Bass Dynamic (Max volume: {this.Volume}, current volume: {GetDynamicVolumeLevel() * 100}%)";
        }
    }
}
