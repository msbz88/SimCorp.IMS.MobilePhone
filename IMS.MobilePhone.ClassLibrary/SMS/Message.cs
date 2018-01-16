using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public class Message {
        public delegate string MessageComponents();
        private static int MessageId { get; set; }
        public string User { get; set; }
        public string Text { get; set; }
        public DateTime ReceivinigTime { get; set; }

        public Message(string user, string text) {
            this.User = user;
            this.Text = text;
            this.ReceivinigTime = DateTime.Now;
        }

        public MessageComponents CombineMessageComponents() {
            MessageComponents messageComponents = AddMessageNumber;
            messageComponents += AddMessageUser;
            messageComponents += AddMessageText;
            messageComponents += AddMessageTime;
            return messageComponents;
        }

        private string AddMessageNumber() {
            return $"Message #{++MessageId}";
        }

        private string AddMessageUser() {
            return $"Form: {this.User}";
        }

        private string AddMessageText() {
            return this.Text;
        }

        private string AddMessageTime() {
            return $"received at: {ReceivinigTime}";
        }
    }
}
