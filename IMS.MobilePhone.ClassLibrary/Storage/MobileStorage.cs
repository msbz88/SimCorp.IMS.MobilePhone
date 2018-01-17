using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System.Collections.Generic;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Storage {
    public class MobileStorage {
        public delegate string MessageAdded();
        public static event MessageAdded OnMessageAdded = new MessageAdded(NotifyMessageAdded);
        public delegate string MessageDeleted();
        public static event MessageDeleted OnMessageDeleted = new MessageDeleted(NotifyMessageRemoved);

        public static List<TextMessage> Messages = new List<TextMessage>();

        public static void AddMessage(TextMessage message) {
            Messages.Add(message);
            OnMessageAdded?.Invoke();
        }

        public static void RemoveMessage(TextMessage message) {
            Messages.Remove(message);
            OnMessageDeleted?.Invoke();
        }

        public static string NotifyMessageAdded() {
            return "Message added.";
        }

        public static string NotifyMessageRemoved() {
            return "Message removed.";
        }
    }
}
