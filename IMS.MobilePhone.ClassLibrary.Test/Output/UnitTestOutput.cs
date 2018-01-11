using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.MobilePhone.ClassLibrary.Headset;
using Simcorp.IMS.MobilePhone.ClassLibrary.Speaker;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Test.Output {
    [TestClass]
    public class UnitTestOutput {
        public string Result { get; set;}

        public void TestIPhoneHeadsetPlay(int volume) {
            IPhoneHeadset iPhoneHeadset = new IPhoneHeadset(volume, new TestOutput(this));
            iPhoneHeadset.Play();
            string expectations = iPhoneHeadset.ToString();
            Assert.AreEqual(expectations, Result);
        }
    
        public void TestIPhoneHeadsetPlay(int volume, string expectations) {
            IPhoneHeadset iPhoneHeadset = new IPhoneHeadset(volume, new TestOutput(this));
            iPhoneHeadset.Play();
            Assert.AreEqual(expectations, Result);
        }
  
        public void TestSamsungHeadsetPlay(int volume) {
            SamsungHeadset samsungHeadset = new SamsungHeadset(volume, new TestOutput(this));
            samsungHeadset.Play();
            string expectations = samsungHeadset.ToString();
            Assert.AreEqual(expectations, Result);
        }
    
        public void TestSamsungHeadsetPlay(int volume, string expectations) {
            SamsungHeadset samsungHeadset = new SamsungHeadset(volume, new TestOutput(this));
            samsungHeadset.Play();
            Assert.AreEqual(expectations, Result);
        }

        public void TestPhoneSpeakerPlay(int volume) {
            PhoneSpeaker phoneSpeaker = new PhoneSpeaker(volume, new TestOutput(this));
            phoneSpeaker.Play();
            string expectations = phoneSpeaker.ToString();
            Assert.AreEqual(expectations, Result);
        }
 
        public void TestPhoneSpeakerPlay(int volume, string expectations) {
            PhoneSpeaker phoneSpeaker = new PhoneSpeaker(volume, new TestOutput(this));
            phoneSpeaker.Play();
            Assert.AreEqual(expectations, Result);
        }
        [TestMethod]
        public void ExecuteAllTests() {
            int samsungVolume = 300;
            int iphoneVolume = 350;
            int speakerVolume = 1500;
            string samsungResultExpectations = $"Audio Type: Samsung Headset (Max volume: {samsungVolume}, current volume: 0%)";
            string iphoneResultExpectations = $"Audio Type: IPhone Headset (Max volume: {iphoneVolume}, current volume: 0%)";
            string speakerResultExpectations = $"Audio Type: Phone Speaker (Max volume: {speakerVolume}, current volume: 0%)";
            TestSamsungHeadsetPlay(samsungVolume);
            TestSamsungHeadsetPlay(samsungVolume, samsungResultExpectations);
            TestIPhoneHeadsetPlay(iphoneVolume);
            TestIPhoneHeadsetPlay(iphoneVolume, iphoneResultExpectations);
            TestPhoneSpeakerPlay(speakerVolume);
            TestPhoneSpeakerPlay(speakerVolume, speakerResultExpectations);
        }
    }
}
