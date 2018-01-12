using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.MobilePhone.ClassLibrary.Headset;
using Simcorp.IMS.MobilePhone.ClassLibrary.Speaker;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Test.Output {
    [TestClass]
    public class UnitTestOutput {
        private static int samsungVolume = 300;
        private static int iphoneVolume = 350;
        private static int speakerVolume = 1500;
        string samsungResultExpectations = $"Audio Type: Samsung Headset (Max volume: {samsungVolume}, current volume: 0%)";
        string iphoneResultExpectations = $"Audio Type: IPhone Headset (Max volume: {iphoneVolume}, current volume: 0%)";
        string speakerResultExpectations = $"Audio Type: Phone Speaker (Max volume: {speakerVolume}, current volume: 0%)";
        public string Result { get; set; }

        [TestMethod]
        public void TestIPhoneHeadsetPlay() {
            IPhoneHeadset iPhoneHeadset = new IPhoneHeadset(iphoneVolume, new TestOutput(this));
            iPhoneHeadset.Play();
            string expectations = iPhoneHeadset.ToString();
            Assert.AreEqual(expectations, Result);
        }
        [TestMethod]
        public void TestIPhoneHeadsetPlayCustom() {
            IPhoneHeadset iPhoneHeadset = new IPhoneHeadset(iphoneVolume, new TestOutput(this));
            iPhoneHeadset.Play();
            Assert.AreEqual(iphoneResultExpectations, Result);
        }
        [TestMethod]
        public void TestSamsungHeadsetPlay() {
            SamsungHeadset samsungHeadset = new SamsungHeadset(samsungVolume, new TestOutput(this));
            samsungHeadset.Play();
            string expectations = samsungHeadset.ToString();
            Assert.AreEqual(expectations, Result);
        }
        [TestMethod]
        public void TestSamsungHeadsetPlayCustom() {
            SamsungHeadset samsungHeadset = new SamsungHeadset(samsungVolume, new TestOutput(this));
            samsungHeadset.Play();
            Assert.AreEqual(samsungResultExpectations, Result);
        }
        [TestMethod]
        public void TestPhoneSpeakerPlay() {
            PhoneSpeaker phoneSpeaker = new PhoneSpeaker(speakerVolume, new TestOutput(this));
            phoneSpeaker.Play();
            string expectations = phoneSpeaker.ToString();
            Assert.AreEqual(expectations, Result);
        }
        [TestMethod]
        public void TestPhoneSpeakerPlayCustom() {
            PhoneSpeaker phoneSpeaker = new PhoneSpeaker(speakerVolume, new TestOutput(this));
            phoneSpeaker.Play();
            Assert.AreEqual(speakerResultExpectations, Result);
        }
    }
}
