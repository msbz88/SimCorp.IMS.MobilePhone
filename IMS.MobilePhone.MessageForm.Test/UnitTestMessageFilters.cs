using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using Simcorp.IMS.MobilePhone.ClassLibrary.Storage;
using System.Collections.Generic;
using System;
using System.Linq;
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
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
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
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
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
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
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
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
            ExpectationsList.Clear();
            MobileStorage.Messages.Clear();
            ResultList = MessagesFilters.GetMessagesDate(MobileStorage.Messages, DateTime.Now.AddDays(1), DateTime.Now);
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
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
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
            ExpectationsList.Clear();
            MobileStorage.Messages.Clear();
            ResultList = MessagesFilters.GetMessagesDate(MobileStorage.Messages, DateTime.Now, DateTime.Now.AddDays(-1));
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
        [TestMethod]
        public void TestGetMessagesUserAndContent() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello1");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message3);
            ResultList = MessagesFilters.GetMessagesUserAndContent(MobileStorage.Messages, "User1", "Hello1");
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
        [TestMethod]
        public void TestGetMessagesUserOrContent() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello1");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message1);
            ExpectationsList.Add(message2);
            ExpectationsList.Add(message3);
            ResultList = MessagesFilters.GetMessagesUserOrContent(MobileStorage.Messages, "User1", "Hello");
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
        [TestMethod]
        public void TestGetMessagesUserAndDate() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello1");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message2);
            ExpectationsList.Add(message3);
            ResultList = MessagesFilters.GetMessagesUserAndDate(MobileStorage.Messages, "User1", DateTime.Now, DateTime.Now);
            ExpectationsList.OrderBy(message => message.User).ThenBy(message => message.Text);
            ResultList.OrderBy(message => message.User).ThenBy(message => message.Text);
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
        [TestMethod]
        public void TestGetMessagesUserOrDate() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello1");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message1);
            ExpectationsList.Add(message2);
            ExpectationsList.Add(message3);
            ResultList = MessagesFilters.GetMessagesUserOrDate(MobileStorage.Messages, "User1", DateTime.Now, DateTime.Now);
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
          
        }
        [TestMethod]
        public void TestGetMessagesUserAndContentAndDate() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello1");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message3);
            ResultList = MessagesFilters.GetMessagesUserAndContentAndDate(MobileStorage.Messages, "User1", "Hello1",  DateTime.Now, DateTime.Now);
            ExpectationsList.OrderBy(message => message.User).ThenBy(message => message.Text);
            ResultList.OrderBy(message => message.User).ThenBy(message => message.Text);
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
        [TestMethod]
        public void TestGetMessagesContentAndDate() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User1", "Hell");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello1");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message1);
            ExpectationsList.Add(message3);
            ResultList = MessagesFilters.GetMessagesContentAndDate(MobileStorage.Messages, "Hello", DateTime.Now, DateTime.Now);
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
        [TestMethod]
        public void TestGetMessagesContentOrDate() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello1");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message1);
            ExpectationsList.Add(message2);
            ExpectationsList.Add(message3);
            ResultList = MessagesFilters.GetMessagesContentOrDate(MobileStorage.Messages, "Hello", DateTime.Now, DateTime.Now);
            ExpectationsList.OrderBy(message => message.User).ThenBy(message => message.Text);
            ResultList.OrderBy(message => message.User).ThenBy(message => message.Text);
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
        [TestMethod]
        public void TestGetMessagesUserOrContentAndDate() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello1");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message1);
            ExpectationsList.Add(message2);
            ExpectationsList.Add(message3);
            ResultList = MessagesFilters.GetMessagesContentOrDate(MobileStorage.Messages, "Hello", DateTime.Now, DateTime.Now);
            ExpectationsList.OrderBy(message => message.User).ThenBy(message => message.Text);
            ResultList.OrderBy(message => message.User).ThenBy(message => message.Text);
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
        [TestMethod]
        public void TestGetMessagesUserAndContentOrDate() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello1");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message1);
            ExpectationsList.Add(message2);
            ExpectationsList.Add(message3);
            ResultList = MessagesFilters.GetMessagesUserAndContentOrDate(MobileStorage.Messages, "User1", "Hello", DateTime.Now, DateTime.Now);
            ExpectationsList.OrderBy(message => message.User).ThenBy(message => message.Text);
            ResultList.OrderBy(message => message.User).ThenBy(message => message.Text);
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
        [TestMethod]
        public void TestGetMessagesUserAndDateOrContent() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello1");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message2);
            ExpectationsList.Add(message3);
            ResultList = MessagesFilters.GetMessagesUserAndDateOrContent(MobileStorage.Messages, "User1", "Hello1", DateTime.Now, DateTime.Now);
            ExpectationsList.OrderBy(message => message.User).ThenBy(message => message.Text);
            ResultList.OrderBy(message => message.User).ThenBy(message => message.Text);
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
    }
}

