using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public class SMSProvider {
        public delegate void SMSRecievedDelegate(string message);
        public event SMSRecievedDelegate SMSRecieved;
        public delegate string FormatDelegate(string text);

        private static int MessageId { get; set; }

        public void RaiseSMSReceivedEvent(string message) {
            SMSRecieved?.Invoke(message);
        }

        public static string SendMessage() {
            return $"Message #{++MessageId} received";
        }

        public static string FormatNone(string message) {
           return message;
        }

        public static string FormatWithTimeBefore(string message) {
            return $"[{DateTime.Now}] {message}";
        }

        public static string FormatWithTimeAfter(string message) {
            return $"{message} [{DateTime.Now}]";
        }

        public static string FormatWithUpperCase(string message) {
            return message.ToUpper();
        }

        public static string FormatWithLowerCase(string message) {
            return message.ToLower();
        }

        public static string FormatWithSmile(string message) {
            return $"{message} =)";
        }
    }
}
