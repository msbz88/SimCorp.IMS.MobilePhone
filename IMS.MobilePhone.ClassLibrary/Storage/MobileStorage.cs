using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System.Collections.Generic;
using Simcorp.IMS.MobilePhone.ClassLibrary.Contacts;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Storage {
    public class MobileStorage {
        public delegate string StorageNotification();
        public static event StorageNotification OnMessageAdded;
        public static event StorageNotification OnMessageDeleted;

        public static List<TextMessage> Messages = new List<TextMessage>();
        public static List<Call> CallsHistory = new List<Call>();
        public static List<Call> CallGroups = new List<Call>();

        public static void AddMessage(TextMessage message) {
            Messages.Add(message);
            OnMessageAdded?.Invoke();
        }

        public static void RemoveMessage(TextMessage message) {
            Messages.Remove(message);
            OnMessageDeleted?.Invoke();
        }

        public static void AddCallToHistory(Call call) {
            CallsHistory.Add(call);
            CallsHistory.Sort();
        }

        public static void RemoveCallFromHistory(Call call) {
            CallsHistory.Remove(call);
            CallsHistory.Sort();
        }

        public static void AddCallToGroup(Call call) {
            CallGroups.Add(call);
            CallGroups.Sort();
        }

        public static void RemoveCallFromGroup(Call call) {
            CallGroups.Remove(call);
            CallGroups.Sort();
        }
    }
}
