using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using Simcorp.IMS.MobilePhone.ClassLibrary.Storage;
using System.Collections.Generic;
using System;
using Simcorp.IMS.MobilePhone.MessageForm;

namespace Simcorp.IMS.MobilePhone.MessageForm.Test {
    [TestClass]
    public class UnitTestMessageFilters {
        public static TextMessage testMessage = new TextMessage("User", "Hello");
        public List<TextMessage> ResultList = new List<TextMessage>();
        public List<TextMessage> ExpectationsList = new List<TextMessage>();
        FormMessageFormating formMessageFormating = new FormMessageFormating();

        [TestMethod]
        public void TestGetMessagesUser() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Add(message1);
            ExpectationsList.Add(message2);
            ResultList = MessagesFilters.GetMessagesUser(MobileStorage.Messages, testMessage.User);
            Assert.AreEqual(ExpectationsList.Count, ResultList.Count);
            foreach (TextMessage messageExp in ExpectationsList) {
                foreach (TextMessage messageRes in ResultList) {
                    Assert.AreEqual(messageExp.User, messageRes.User);
                }
            }
        }

        [TestMethod]
        public void TestGetMessagesContent() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User", "M");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "m");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message2);
            ResultList = MessagesFilters.GetMessagesContent(MobileStorage.Messages, "M");
            Assert.AreEqual(ExpectationsList.Count, ResultList.Count);
            foreach (TextMessage messageExp in ExpectationsList) {
                foreach (TextMessage messageRes in ResultList) {
                    Assert.AreEqual(messageExp.Text, messageRes.Text);
                }
            }
        }

        [TestMethod]
        public void TestGetMessagesDateToday() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message1);
            ExpectationsList.Add(message2);
            ExpectationsList.Add(message3);
            ResultList = MessagesFilters.GetMessagesDate(MobileStorage.Messages, DateTime.Now, DateTime.Now);
            Assert.AreEqual(ExpectationsList.Count, ResultList.Count);
            foreach (TextMessage messageExp in ExpectationsList) {
                foreach (TextMessage messageRes in ResultList) {
                    Assert.AreEqual(messageExp.ReceivinigTime.Date, messageRes.ReceivinigTime.Date);
                }
            }
        }

        [TestMethod]
        public void TestGetMessagesDatePlusDay() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message1);
            ExpectationsList.Add(message2);
            ExpectationsList.Add(message3);
            ResultList = MessagesFilters.GetMessagesDate(MobileStorage.Messages, DateTime.Now, DateTime.Now.AddDays(1));
            Assert.AreEqual(ExpectationsList.Count, ResultList.Count);
            foreach (TextMessage messageExp in ExpectationsList) {
                foreach (TextMessage messageRes in ResultList) {
                    Assert.AreEqual(messageExp.ReceivinigTime.Date, messageRes.ReceivinigTime.Date);
                }
            }
            ExpectationsList.Clear();
            MobileStorage.Messages.Clear();
            ResultList = MessagesFilters.GetMessagesDate(MobileStorage.Messages, DateTime.Now.AddDays(1), DateTime.Now);
            Assert.AreEqual(ExpectationsList.Count, ResultList.Count);
            foreach (TextMessage messageExp in ExpectationsList) {
                foreach (TextMessage messageRes in ResultList) {
                    Assert.AreEqual(messageExp.ReceivinigTime.Date, messageRes.ReceivinigTime.Date);
                }
            }
        }

        [TestMethod]
        public void TestGetMessagesDateMinusDay() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message1);
            ExpectationsList.Add(message2);
            ExpectationsList.Add(message3);
            ResultList = MessagesFilters.GetMessagesDate(MobileStorage.Messages, DateTime.Now.AddDays(-1), DateTime.Now);
            Assert.AreEqual(ExpectationsList.Count, ResultList.Count);
            foreach (TextMessage messageExp in ExpectationsList) {
                foreach (TextMessage messageRes in ResultList) {
                    Assert.AreEqual(messageExp.ReceivinigTime.Date, messageRes.ReceivinigTime.Date);
                }
            }
            ExpectationsList.Clear();
            MobileStorage.Messages.Clear();
            ResultList = MessagesFilters.GetMessagesDate(MobileStorage.Messages, DateTime.Now, DateTime.Now.AddDays(-1));
            Assert.AreEqual(ExpectationsList.Count, ResultList.Count);
            foreach (TextMessage messageExp in ExpectationsList) {
                foreach (TextMessage messageRes in ResultList) {
                    Assert.AreEqual(messageExp.ReceivinigTime.Date, messageRes.ReceivinigTime.Date);
                }
            }
        }
    }
}
