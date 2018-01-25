using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Contact {
    public class Call : IComparable<Call> {
        public Contact Contact { get; set; }
        public DateTime ReceivedTime { get; set; }
        public string CallDirection { get; set; }

        public Call(Contact contact, DateTime receivedTime, string callDirection) {
            Contact = contact;
            ReceivedTime = receivedTime;
            CallDirection = callDirection;
        }

        public int CompareTo(Call call) {
            if (this.ReceivedTime == call.ReceivedTime) {
                return this.Contact.ContactName.CompareTo(call.Contact);
            }
            return call.ReceivedTime.CompareTo(this.ReceivedTime);
        }
    }
}
