using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;

namespace Simcorp.IMS.MobilePhone.MessageForm.Test {
    [TestClass]
    public class UnitTestMessageFormatting {
        FormMessageFormating formMessageFormating = new FormMessageFormating();
        public static TextMessage testMessage = new TextMessage("User", "Hello");
        public static string Result { get; set; }
        public static string WithoutFormattingExp = $"Message #{TextMessage.MessageId}\nForm: {testMessage.User}\n{testMessage.Text}\nreceived at: {testMessage.ReceivinigTime}\n";
        public static string BeginWithTimeFormattingExp = $"Received at: { testMessage.ReceivinigTime}\nMessage #{TextMessage.MessageId}\nForm: {testMessage.User}\n{testMessage.Text}\n";
        public static string UpperMessageTextFormattingExp = $"Message #{TextMessage.MessageId}\nForm: {testMessage.User}\n{testMessage.Text.ToUpper()}\nreceived at: {testMessage.ReceivinigTime}\n";
        public static string UpperMessageUserAndTimeFormattingExp = $"Message #{TextMessage.MessageId}\nFROM: {testMessage.User.ToUpper()}\n{testMessage.Text}\nRESEIVED AT: {testMessage.ReceivinigTime}\n";
        public static string LowerMessageTextFormattingExp = $"Message #{TextMessage.MessageId}\nForm: {testMessage.User}\n{testMessage.Text.ToLower()}\nreceived at: {testMessage.ReceivinigTime}\n";

        [TestMethod]
        public void TestWithoutFormatting() {
            formMessageFormating.Formatter += MessageFormats.WithoutFormatting;
            formMessageFormating.OnSMSReceived(testMessage);
            Result = formMessageFormating.FormattedMessage;
            Assert.AreEqual(WithoutFormattingExp, Result);
        }
        [TestMethod]
        public void TestBeginWithTimeFormatting() {
            formMessageFormating.Formatter += MessageFormats.BeginWithTimeFormatting;
            formMessageFormating.OnSMSReceived(testMessage);
            Result = formMessageFormating.FormattedMessage;
            Assert.AreEqual(BeginWithTimeFormattingExp, Result);
        }
        [TestMethod]
        public void TestUpperMessageTextFormatting() {
            formMessageFormating.Formatter += MessageFormats.UpperMessageTextFormatting;
            formMessageFormating.OnSMSReceived(testMessage);
            Result = formMessageFormating.FormattedMessage;
            Assert.AreEqual(UpperMessageTextFormattingExp, Result);
        }
        [TestMethod]
        public void TestUpperMessageUserAndTimeFormatting() {
            formMessageFormating.Formatter += MessageFormats.UpperMessageUserAndTimeFormatting;
            formMessageFormating.OnSMSReceived(testMessage);
            Result = formMessageFormating.FormattedMessage;
            Assert.AreEqual(UpperMessageUserAndTimeFormattingExp, Result);
        }
        [TestMethod]
        public void TestLowerMessageTextFormatting() {
            formMessageFormating.Formatter += MessageFormats.LowerMessageTextFormatting;
            formMessageFormating.OnSMSReceived(testMessage);
            Result = formMessageFormating.FormattedMessage;
            Assert.AreEqual(LowerMessageTextFormattingExp, Result);
        }
    }
}
