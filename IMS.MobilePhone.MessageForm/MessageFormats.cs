using System;
using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public class MessageFormats {
        public delegate string FormatDelegate(TextMessage message);

        public static string WithoutFormatting(TextMessage message) {
            return $"Message #{TextMessage.MessageId}\nForm: {message.User}\n{message.Text}\nreceived at: {message.ReceivinigTime}\n";
        }

        public static string BeginWithTimeFormatting(TextMessage message) {
            return $"Received at: { message.ReceivinigTime}\nMessage #{TextMessage.MessageId}\nForm: {message.User}\n{message.Text}\n";
        }

        public static string UpperMessageTextFormatting(TextMessage message) {
            return $"Message #{TextMessage.MessageId}\nForm: {message.User}\n{message.Text.ToUpper()}\nreceived at: {message.ReceivinigTime}\n";
        }

        public static string LowerMessageTextFormatting(TextMessage message) {
            return $"Message #{TextMessage.MessageId}\nForm: {message.User}\n{message.Text.ToLower()}\nreceived at: {message.ReceivinigTime}\n";
        }

        public static string UpperMessageUserAndTimeFormatting(TextMessage message) {
            return $"Message #{TextMessage.MessageId}\nFROM: {message.User.ToUpper()}\n{message.Text}\nRESEIVED AT: {message.ReceivinigTime}\n";
        }
    }
}
