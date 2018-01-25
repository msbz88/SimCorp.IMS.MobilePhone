using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System.Collections.Generic;
using Simcorp.IMS.MobilePhone.ClassLibrary.Contact;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Storage {
    public class MobileStorage {
        public delegate string StorageNotification();
        public static event StorageNotification OnMessageAdded;
        public static event StorageNotification OnMessageDeleted;

        public static List<TextMessage> Messages = new List<TextMessage>();
        public static List<Call> Calls = new List<Call>();

        public static void AddMessage(TextMessage message) {
            Messages.Add(message);
            OnMessageAdded?.Invoke();
        }

        public static void RemoveMessage(TextMessage message) {
            Messages.Remove(message);
            OnMessageDeleted?.Invoke();
        }

        public static void AddCall(Call call) {
            Calls.Add(call);
            Calls.Sort();
        }

        public static void RemoveCall(Call call) {
            Calls.Remove(call);
            Calls.Sort();
        }
    }
}
