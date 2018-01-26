using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Contacts {
    public class Call : IComparable<Call> {
        public Contact Contact { get; set; }
        public DateTime ReceivedTime { get; set; }
        public string CallDirection { get; set; }
        public int CountTimesCalled { get; set; }

        public Call(Contact contact, DateTime receivedTime, string callDirection) {
            Contact = contact;
            ReceivedTime = receivedTime;
            CallDirection = callDirection;
            CountTimesCalled = 1;
        }

        public int CompareTo(Call call) {
            if (this.ReceivedTime == call.ReceivedTime) {
                return this.Contact.ContactName.CompareTo(call.Contact.ContactName);
            }
            return call.ReceivedTime.CompareTo(this.ReceivedTime);
        }

        public override bool Equals(object obj) {
            Call call = (Call)obj;
            if (Contact.ContactName == call.Contact.ContactName &&
                Contact.MobileNumber == call.Contact.MobileNumber &&
                CallDirection == call.CallDirection) {
                return true;
            } else { return false; }       
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}
