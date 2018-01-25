using System.Collections.Generic;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Contact {
    public class Contact {
        public string ContactName { get; set; }
        public string MobileNumber { get; set; }

        public Contact(string contactName, string mobileNumber) {
            ContactName = contactName;
            MobileNumber = mobileNumber;
        }
    }
}
