using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public class SMSProvider {
        public delegate void SMSRecievedDelegate(string message);
        private delegate string FormatDelegate(string text);

        public event SMSRecievedDelegate SMSRecieved;

        private void RaiseSMSReceivedEvent(string message) {
            var handler = SMSRecieved;
            if (handler != null) {
                handler(message);
            }
        }

        private static string FormatWithTimeBefore(string message) {
            return $"[{DateTime.Now}] {message}";
        }

        private static string FormatWithTimeAfter(string message) {
            return $"{message} [{DateTime.Now}]";
        }

        private static string FormatWithUpperCase(string message) {
            return message.ToUpper();
        }

        private static string FormatWithLowerCase(string message) {
            return message.ToLower();
        }

        private static string FormatWithSmile(string message) {
            return $"{message} =)";
        }
    }
}
