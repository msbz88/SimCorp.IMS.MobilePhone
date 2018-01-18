using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public static class MessagesFilters {
        public static List<TextMessage> GetAllMessagesOfUser(List<TextMessage> messages, string User) {
            return messages.Where(message => message.User == User).ToList();
        }

        public static List<TextMessage> GetMessagesByContent(List<TextMessage> messages, string contains) {
            return messages.Where(message => message.Text.Contains(contains)).ToList();
        }

        public static List<TextMessage> GetMessagesBetweenDates(List<TextMessage> messages, DateTime dateFrom, DateTime dateTo) {
            return messages.Where(message =>
                   message.ReceivinigTime.Date >= dateFrom.Date &&
                   message.ReceivinigTime.Date <= dateTo.Date).ToList();
        }
    }
}
