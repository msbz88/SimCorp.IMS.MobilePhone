using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;

namespace Simcorp.IMS.MobilePhone.MessageForm.Test {
    [TestClass]
    public class UnitTestMessageFormatting {
        public string TestMessage { get; set; } = SMSProvider.SendMessage();
        public string Result { get; set; }
        public string Expectations { get; set; }
        FormMessageFormating formMessageFormating = new FormMessageFormating();

        [TestMethod]
        public void TestFormateNone() {
            formMessageFormating.Formatter += SMSProvider.FormateNone;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Expectations = SMSProvider.FormateNone(TestMessage);
            Assert.AreEqual(Expectations, Result);
        }
        [TestMethod]
        public void TestFormatWithTimeBefore() {
            formMessageFormating.Formatter += SMSProvider.FormatWithTimeBefore;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Expectations = SMSProvider.FormatWithTimeBefore(TestMessage);
            Assert.AreEqual(Expectations, Result);
        }
        [TestMethod]
        public void TestFormatWithTimeAfter() {
            formMessageFormating.Formatter += SMSProvider.FormatWithTimeAfter;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Expectations = SMSProvider.FormatWithTimeAfter(TestMessage);
            Assert.AreEqual(Expectations, Result);
        }
        [TestMethod]
        public void TestFormatWithUpperCase() {
            formMessageFormating.Formatter += SMSProvider.FormatWithUpperCase;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Expectations = SMSProvider.FormatWithUpperCase(TestMessage);
            Assert.AreEqual(Expectations, Result);
        }
        [TestMethod]
        public void TestFormatWithLowerCase() {
            formMessageFormating.Formatter += SMSProvider.FormatWithLowerCase;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Expectations = SMSProvider.FormatWithLowerCase(TestMessage);
            Assert.AreEqual(Expectations, Result);
        }
        [TestMethod]
        public void TestFormatWithSmile() {
            formMessageFormating.Formatter += SMSProvider.FormatWithSmile;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Expectations = SMSProvider.FormatWithSmile(TestMessage);
            Assert.AreEqual(Expectations, Result);
        }
    }
}
