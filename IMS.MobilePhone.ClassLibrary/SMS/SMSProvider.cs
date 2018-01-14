using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public class SMSProvider {
        public delegate void SMSRecievedDelegate(string message);
        public event SMSRecievedDelegate SMSRecieved;

        //public delegate string FormatDelegate(string text);
        // private readonly FormatDelegate Formatter = new SMSProvider.FormatDelegate(SMSProvider.FormatWithTimeBefore);

        public void RaiseSMSReceivedEvent(string message) {
            SMSRecievedDelegate handler = SMSRecieved;
            if (handler != null) {
                handler(message);
            }
        }

        public static string FormatWithTimeBefore(string message) {
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
