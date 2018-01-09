using System;

namespace Simcorp.IMS.MobilePhone.Dynamic {
    class PhoneSpeaker : SpeakerBase {
        public PhoneSpeaker(int volume) : base(volume) {
        }

        public override double GetSpeakerVolumeLevel() {
            if (this.CurrentVolume != 0 && this.Volume != 0) {
                return (double)this.CurrentVolume / (double)this.Volume;
            }
            else { return 0; }
        }

        public override void IncreaseSpeakerVolumeLevel(int currentVolumeStep) {
            if (this.Volume - this.CurrentVolume >= currentVolumeStep) {
                this.CurrentVolume += currentVolumeStep;
            }
            else { Console.WriteLine($"Cannot raise Phone Speaker volume on {currentVolumeStep}, because it will be more then maximum.\n"); }
        }

        public override void DecreaseSpeakerVolumeLevel(int currentVolumeStep) {
            if (this.CurrentVolume >= currentVolumeStep) {
                this.CurrentVolume -= currentVolumeStep;
            }
            else { Console.WriteLine($"Cannot reduce Phone Speaker volume on {currentVolumeStep}, because it will be less then 0.\n"); }
        }

        public override string ToString() {
            return $"Speaker Type: Phone Speaker (Max volume: {this.Volume}, current volume: {GetSpeakerVolumeLevel() * 100}%)";
        }

        public override void Play(object data) {
            Console.WriteLine("Phone Speaker sound.");
        }
    }
}
