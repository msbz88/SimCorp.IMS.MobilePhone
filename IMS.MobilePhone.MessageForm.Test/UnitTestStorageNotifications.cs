using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using Simcorp.IMS.MobilePhone.ClassLibrary.Storage;

namespace Simcorp.IMS.MobilePhone.MessageForm.Test {
    [TestClass]
    public class UnitTestStorageNotifications {
        public static TextMessage testMessage = new TextMessage("User", "Hello");
        public static string Result { get; set; }
        public string AddMessageExp = "System: Message saved.";
        public string RemoveMessageExp = "System: Message removed.";
        FormMessageFormating formMessageFormating = new FormMessageFormating();

        [TestMethod]
        public void TestAddMessage() {
            MobileStorage.AddMessage(testMessage);
            Result = formMessageFormating.NotifyMessageAdded();
            Assert.AreEqual(AddMessageExp, Result);
        }

        [TestMethod]
        public void TestRemoveMessage() {
            MobileStorage.RemoveMessage(testMessage);
            Result = formMessageFormating.NotifyMessageRemoved();
            Assert.AreEqual(RemoveMessageExp, Result);
        }
    }
}
