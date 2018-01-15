using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public class SMSProvider {
        public delegate void SMSRecievedDelegate(string message);
        public event SMSRecievedDelegate SMSRecieved;
        public delegate string FormatDelegate(string text);

        public void RaiseSMSReceivedEvent(string message) {
            SMSRecievedDelegate handler = SMSRecieved;
            if (handler != null) {
                handler(message);
            }
        }

        public static string FormateNone(string message) {
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
