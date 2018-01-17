using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System.Collections.Generic;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Storage {
    public class MobileStorage {
        public static List<TextMessage> Messages = new List<TextMessage>();

        public static void AddMessage(TextMessage message) {
            Messages.Add(message);
        }

        public static void RemoveMessage(TextMessage message) {
            Messages.Remove(message);
        }
    }
}
