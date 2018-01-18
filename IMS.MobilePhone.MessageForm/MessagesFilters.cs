using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public static class MessagesFilters {
        public static List<TextMessage> GetMessagesUser(List<TextMessage> messages, string user) {
            return messages.Where(message => message.User == user).ToList();
        }

        public static List<TextMessage> GetMessagesContent(List<TextMessage> messages, string contains) {
            return messages.Where(message => message.Text.Contains(contains)).ToList();
        }

        public static List<TextMessage> GetMessagesDate(List<TextMessage> messages, DateTime dateFrom, DateTime dateTo) {
            return messages.Where(message =>
                   message.ReceivinigTime.Date >= dateFrom.Date &&
                   message.ReceivinigTime.Date <= dateTo.Date).ToList();
        }

        public static List<TextMessage> GetMessagesUserAndContent(List<TextMessage> messages, string user, string contains) {
            return GetMessagesContent(GetMessagesUser(messages, user), contains);
        }

        public static List<TextMessage> GetMessagesUserOrContent(List<TextMessage> messages, string user, string contains) {
            return GetMessagesUser(messages, user).Concat(GetMessagesContent(messages, contains)).ToList();
        }

        public static List<TextMessage> GetMessagesUserAndDate(List<TextMessage> messages, string user, DateTime dateFrom, DateTime dateTo) {
            return GetMessagesDate(GetMessagesUser(messages, user), dateFrom, dateTo);
        }

        public static List<TextMessage> GetMessagesUserOrDate(List<TextMessage> messages, string user, DateTime dateFrom, DateTime dateTo) {
            return GetMessagesUser(messages, user).Concat(GetMessagesDate(messages, dateFrom, dateTo)).ToList();
        }

        public static List<TextMessage> GetMessagesUserAndContentAndDate(List<TextMessage> messages, string user, string contains, DateTime dateFrom, DateTime dateTo) {
            return GetMessagesDate(GetMessagesUserAndContent(messages, user, contains), dateFrom, dateTo);
        }

        public static List<TextMessage> GetMessagesUserOrContentOrDate(List<TextMessage> messages, string user, string contains, DateTime dateFrom, DateTime dateTo) {
            return GetMessagesUserOrContent(messages, user, contains).Concat(GetMessagesUserAndDate(messages, user, dateFrom, dateTo)).ToList();
        }

        public static List<TextMessage> GetMessagesContentAndDate(List<TextMessage> messages, string contains, DateTime dateFrom, DateTime dateTo) {
            return GetMessagesDate(GetMessagesContent(messages, contains), dateFrom, dateTo);
        }

        public static List<TextMessage> GetMessagesContentOrDate(List<TextMessage> messages, string contains, DateTime dateFrom, DateTime dateTo) {
            return GetMessagesDate(messages, dateFrom, dateTo).Concat(GetMessagesContent(messages, contains)).ToList();
        }

        public static List<TextMessage> GetMessagesUserOrContentAndDate(List<TextMessage> messages, string user, string contains, DateTime dateFrom, DateTime dateTo) {
            return GetMessagesContentAndDate(messages, contains, dateFrom, dateTo).Concat(GetMessagesUser(messages, user)).ToList();
        }

        public static List<TextMessage> GetMessagesUserAndContentOrDate(List<TextMessage> messages, string user, string contains, DateTime dateFrom, DateTime dateTo) {
            return GetMessagesContent(GetMessagesUser(messages, user), contains).Concat(GetMessagesDate(messages, dateFrom, dateTo)).ToList();
        }

        public static List<TextMessage> GetMessagesUserAndDateOrContent(List<TextMessage> messages, string user, string contains, DateTime dateFrom, DateTime dateTo) {
            return GetMessagesUserAndDate(messages, user, dateFrom, dateTo).Concat(GetMessagesContent(messages, contains)).ToList();
        }
    }
}
