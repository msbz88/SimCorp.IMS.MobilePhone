using System;

namespace Simcorp.IMS.MobilePhone.Headset {
    class SamsungHeadset : IPlayback{
        public void Play(object data) {
            Console.WriteLine("Samsung Headset sound.");
        }
    }
}
