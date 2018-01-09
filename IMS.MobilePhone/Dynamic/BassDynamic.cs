using System;

namespace Simcorp.IMS.MobilePhone.Dynamic {
    class BassDynamic : DynamicBase {
        public BassDynamic(int volume) : base(volume) {
            this.CurrentVolumeStep = 50;
        }

        public override double GetDynamicVolumeLevel() {
            if (this.CurrentVolume != 0 && this.Volume != 0) {
                return (double)this.CurrentVolume / (double)this.Volume;
            }
            else { return 0; }
        }

        public override void IncreaseDynamicVolumeLevel() {
            if(this.Volume - this.CurrentVolume >= CurrentVolumeStep) {
                this.CurrentVolume += CurrentVolumeStep;
            }
        }

        public override void DecreaseDynamicVolumeLevel() {
            if (this.CurrentVolume >= CurrentVolumeStep) {
                this.CurrentVolume -= CurrentVolumeStep;
            }
        }

        public override string ToString() {
            return $"Bass Dynamic (Max volume: {this.Volume}, current volume: {GetDynamicVolumeLevel() * 100}%)";
        }
    }
}
