using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;

namespace Simcorp.IMS.MobilePhone.MessageForm.Test {
    [TestClass]
    public class UnitTestMessageFormatting {
        public string TestMessage { get; set; }
        public string Result { get; set; }
        public string Expectations { get; set; }

        [TestMethod]
        public void TestFormateNone() {
            TestMessage = SMSProvider.SendMessage();
            FormMessageFormating formMessageFormating = new FormMessageFormating();
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Expectations = SMSProvider.FormateNone(TestMessage);
            Assert.AreEqual(Expectations, Result);
        }
        [TestMethod]
        public void TestFormatWithTimeBefore() {
            TestMessage = SMSProvider.SendMessage();
            FormMessageFormating formMessageFormating = new FormMessageFormating();
            formMessageFormating.Formatter += SMSProvider.FormatWithTimeBefore;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Expectations = SMSProvider.FormatWithTimeBefore(TestMessage);
            Assert.AreEqual(Expectations, Result);
        }
        [TestMethod]
        public void TestFormatWithTimeAfter() {
            TestMessage = SMSProvider.SendMessage();
            FormMessageFormating formMessageFormating = new FormMessageFormating();
            formMessageFormating.Formatter += SMSProvider.FormatWithTimeAfter;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Expectations = SMSProvider.FormatWithTimeAfter(TestMessage);
            Assert.AreEqual(Expectations, Result);
        }
        [TestMethod]
        public void TestFormatWithUpperCase() {
            TestMessage = SMSProvider.SendMessage();
            FormMessageFormating formMessageFormating = new FormMessageFormating();
            formMessageFormating.Formatter += SMSProvider.FormatWithUpperCase;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Expectations = SMSProvider.FormatWithUpperCase(TestMessage);
            Assert.AreEqual(Expectations, Result);
        }
        [TestMethod]
        public void TestFormatWithLowerCase() {
            TestMessage = SMSProvider.SendMessage();
            FormMessageFormating formMessageFormating = new FormMessageFormating();
            formMessageFormating.Formatter += SMSProvider.FormatWithLowerCase;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Expectations = SMSProvider.FormatWithLowerCase(TestMessage);
            Assert.AreEqual(Expectations, Result);
        }
        [TestMethod]
        public void TestFormatWithSmile() {
            TestMessage = SMSProvider.SendMessage();
            FormMessageFormating formMessageFormating = new FormMessageFormating();
            formMessageFormating.Formatter += SMSProvider.FormatWithSmile;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Expectations = SMSProvider.FormatWithSmile(TestMessage);
            Assert.AreEqual(Expectations, Result);
        }
    }
}
