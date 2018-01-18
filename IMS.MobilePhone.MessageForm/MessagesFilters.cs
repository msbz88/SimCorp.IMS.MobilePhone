using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public static class MessagesFilters {
        public static List<TextMessage> GetAllMessagesOfUser(List<TextMessage> messages, string user) {
            return messages.Where(message => message.User == user).ToList();
        }

        public static List<TextMessage> GetMessagesByContent(List<TextMessage> messages, string contains) {
            return messages.Where(message => message.Text.Contains(contains)).ToList();
        }

        public static List<TextMessage> GetMessagesBetweenDates(List<TextMessage> messages, DateTime dateFrom, DateTime dateTo) {
            return messages.Where(message =>
                   message.ReceivinigTime.Date >= dateFrom.Date &&
                   message.ReceivinigTime.Date <= dateTo.Date).ToList();
        }

        public static List<TextMessage> GetAllMessagesOfUserByContent(List<TextMessage> messages, string user, string contains) {
            return GetMessagesByContent(GetAllMessagesOfUser(messages, user), contains);
        }

        public static List<TextMessage> GetAllMessagesOfUserOrByContent(List<TextMessage> messages, string user, string contains) {
            return GetAllMessagesOfUser(messages, user).Concat(GetMessagesByContent(messages, contains)).ToList();
        }

        public static List<TextMessage> GetAllMessagesOfUserByDate(List<TextMessage> messages, string user, DateTime dateFrom, DateTime dateTo) {
            return GetMessagesBetweenDates(GetAllMessagesOfUser(messages, user), dateFrom, dateTo);
        }

        public static List<TextMessage> GetAllMessagesOfUserOrByDate(List<TextMessage> messages, string user, DateTime dateFrom, DateTime dateTo) {
            return GetAllMessagesOfUser(messages, user).Concat(GetMessagesBetweenDates(messages, dateFrom, dateTo)).ToList();
        }

        public static List<TextMessage> GetAllMessagesOfUserByContentByDate(List<TextMessage> messages, string user, string contains, DateTime dateFrom, DateTime dateTo) {
            return GetMessagesBetweenDates(GetAllMessagesOfUserByContent(messages, user, contains), dateFrom, dateTo);
        }

        public static List<TextMessage> GetAllMessagesOfUserOrByContentOrByDate(List<TextMessage> messages, string user, string contains, DateTime dateFrom, DateTime dateTo) {
            return GetAllMessagesOfUserOrByContent(messages, user, contains).Concat(GetAllMessagesOfUserByDate(messages, user, dateFrom, dateTo)).ToList();
        }

        public static List<TextMessage> GetMessagesByContentByDate(List<TextMessage> messages, string contains, DateTime dateFrom, DateTime dateTo) {
            return GetMessagesBetweenDates(GetMessagesByContent(messages, contains), dateFrom, dateTo);
        }

        public static List<TextMessage> GetMessagesByContentOrByDate(List<TextMessage> messages, string contains, DateTime dateFrom, DateTime dateTo) {
            return GetMessagesBetweenDates(messages, dateFrom, dateTo).Concat(GetMessagesByContent(messages, contains)).ToList();
        }

        public static List<TextMessage> GetMessagesByContentByDateOrUser(List<TextMessage> messages, string user, string contains, DateTime dateFrom, DateTime dateTo) {
            return GetMessagesByContentByDate(messages, contains, dateFrom, dateTo).Concat(GetAllMessagesOfUser(messages, user)).ToList();
        }

        public static List<TextMessage> GetAllMessagesOfUserByContentOrDate(List<TextMessage> messages, string user, string contains, DateTime dateFrom, DateTime dateTo) {
            return GetMessagesByContent(GetAllMessagesOfUser(messages, user), contains).Concat(GetMessagesBetweenDates(messages, dateFrom, dateTo)).ToList();
        }

        public static List<TextMessage> GetAllMessagesOfUserByDateOrSearch(List<TextMessage> messages, string user, string contains, DateTime dateFrom, DateTime dateTo) {
            return GetAllMessagesOfUserByDate(messages, user, dateFrom, dateTo).Concat(GetMessagesByContent(messages, contains)).ToList();
        }
    }
}
