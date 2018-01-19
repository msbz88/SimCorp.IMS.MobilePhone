using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using Simcorp.IMS.MobilePhone.ClassLibrary.Storage;
using System.Collections.Generic;
using System;
using System.Linq;
using Simcorp.IMS.MobilePhone.MessageForm;
using static Simcorp.IMS.MobilePhone.ClassLibrary.Storage.MobileStorage;

namespace Simcorp.IMS.MobilePhone.MessageForm.Test {
    [TestClass]
    public class UnitTestMessageFilters {
        public static TextMessage testMessage = new TextMessage("User", "Hello");
        public List<TextMessage> ResultList = new List<TextMessage>();
        public List<TextMessage> ExpectationsList = new List<TextMessage>();
        FormMessageFormating formMessageFormating = new FormMessageFormating();

        [TestMethod]
        public void TestFiltersUserAndContent() {
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
            ResultList = formMessageFormating.Filters(Messages, "User", "o", DateTime.Now, DateTime.Now, false, false);
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
        [TestMethod]
        public void TestFiltersContent() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User", "Ms");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "m");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message2);
            ResultList = formMessageFormating.Filters(Messages, "All", "s", DateTime.Now, DateTime.Now, false, false);
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
        [TestMethod]
        public void TestFiltersUser() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message3);
            ResultList = formMessageFormating.Filters(Messages, "User1", "", DateTime.Now, DateTime.Now, false, false);
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
        [TestMethod]
        public void TestFiltersContentOrDate() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "ello");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message1);
            ExpectationsList.Add(message2);
            ExpectationsList.Add(message3);
            ResultList = formMessageFormating.Filters(Messages, "All", "H", DateTime.Now, DateTime.Now, false, true);
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
        [TestMethod]
        public void TestFiltersUserOrContent() {
            MobileStorage.Messages.Clear();
            SMSProvider SMSProvider = new SMSProvider(formMessageFormating);
            TextMessage message1 = new TextMessage("User", "Hello1");
            SMSProvider.SendMessage(message1);
            TextMessage message2 = new TextMessage("User", "Hello");
            SMSProvider.SendMessage(message2);
            TextMessage message3 = new TextMessage("User1", "Hello");
            SMSProvider.SendMessage(message3);
            ExpectationsList.Clear();
            ExpectationsList.Add(message1);
            ExpectationsList.Add(message3);
            ResultList = formMessageFormating.Filters(Messages, "User1", "Hello1", DateTime.Now, DateTime.Now, true, false);
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
        [TestMethod]
        public void TestFiltersUserOrDate() {
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
            ResultList = formMessageFormating.Filters(Messages, "User", "", DateTime.Now, DateTime.Now, false, true);
            CollectionAssert.AreEqual(ExpectationsList, ResultList);
        }
    }
}

