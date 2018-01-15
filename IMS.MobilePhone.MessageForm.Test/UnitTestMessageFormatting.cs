using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;

namespace Simcorp.IMS.MobilePhone.MessageForm.Test {
    [TestClass]
    public class UnitTestMessageFormatting {
        FormMessageFormating formMessageFormating = new FormMessageFormating();
        public static string TestMessage { get; set; } = "Message #1 received";
        public static string Result { get; set; }
        public static string FormatNoneExp = "Message #1 received";
        public static string FormatWithTimeBeforeExp = $"[{DateTime.Now}] Message #1 received";
        public static string FormatWithTimeAfterExp = $"Message #1 received [{DateTime.Now}]";
        public static string FormatWithUpperCaseExp = "MESSAGE #1 RECEIVED";
        public static string FormatWithLowerCaseExp = "message #1 received";
        public static string FormatWithSmileExp = "Message #1 received =)";

        [TestMethod]
        public void TestFormatNone() {
            formMessageFormating.Formatter += SMSProvider.FormatNone;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Assert.AreEqual(FormatNoneExp, Result);
        }
        [TestMethod]
        public void TestFormatWithTimeBefore() {
            formMessageFormating.Formatter += SMSProvider.FormatWithTimeBefore;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Assert.AreEqual(FormatWithTimeBeforeExp, Result);
        }
        [TestMethod]
        public void TestFormatWithTimeAfter() {
            formMessageFormating.Formatter += SMSProvider.FormatWithTimeAfter;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Assert.AreEqual(FormatWithTimeAfterExp, Result);
        }
        [TestMethod]
        public void TestFormatWithUpperCase() {
            formMessageFormating.Formatter += SMSProvider.FormatWithUpperCase;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Assert.AreEqual(FormatWithUpperCaseExp, Result);
        }
        [TestMethod]
        public void TestFormatWithLowerCase() {
            formMessageFormating.Formatter += SMSProvider.FormatWithLowerCase;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Assert.AreEqual(FormatWithLowerCaseExp, Result);
        }
        [TestMethod]
        public void TestFormatWithSmile() {
            formMessageFormating.Formatter += SMSProvider.FormatWithSmile;
            formMessageFormating.OnSMSReceived(TestMessage);
            Result = formMessageFormating.FormattedMessage;
            Assert.AreEqual(FormatWithSmileExp, Result);
        }
    }
}
