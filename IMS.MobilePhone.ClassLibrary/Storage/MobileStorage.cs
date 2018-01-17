using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System.Collections.Generic;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Storage {
    public class MobileStorage {
        public delegate void StorageNotification();
        public static event StorageNotification OnMessageAdded;
        public static event StorageNotification OnMessageDeleted;

        public static List<TextMessage> Messages = new List<TextMessage>();

        public static void AddMessage(TextMessage message) {
            Messages.Add(message);
            OnMessageAdded?.Invoke();
        }

        public static void RemoveMessage(TextMessage message) {
            Messages.Remove(message);
            OnMessageDeleted?.Invoke();
        }
    }
}
