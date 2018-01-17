using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public class TextMessage {
        public delegate string MessageComponents();
        public static int MessageId { get; set; }
        public string User { get; set; }
        public string Text { get; set; }
        public DateTime ReceivinigTime { get; set; }

        public TextMessage(string user, string text) {
            ++MessageId;
            this.User = user;
            this.Text = text;
            this.ReceivinigTime = DateTime.Now;
        }
    }
}
