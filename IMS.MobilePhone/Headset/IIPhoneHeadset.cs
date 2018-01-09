using System;

namespace Simcorp.IMS.MobilePhone.Headset {
    class IIPhoneHeadset : IPlayback {
        public void Play(object data) {
            Console.WriteLine("IPhone Headset sound.");
        }
    }
}
