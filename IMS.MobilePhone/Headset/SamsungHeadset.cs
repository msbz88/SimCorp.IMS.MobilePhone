﻿using System;
using Simcorp.IMS.MobilePhone.Audio;

namespace Simcorp.IMS.MobilePhone.Headset {
    class SamsungHeadset : IPlayback  {
        public AudioController AudioController = new AudioController(0);

        public SamsungHeadset(int maxVolume) {
            AudioController.MaxVolume = maxVolume;
        }

        public override string ToString() {
            return $"Audio Type: Samsung Headset (Max volume: {AudioController.MaxVolume}, current volume: {AudioController.GetAudioVolumeLevel() * 100}%)";
        }

        public void Play() {
            Console.WriteLine(this);
        }
    }
}
