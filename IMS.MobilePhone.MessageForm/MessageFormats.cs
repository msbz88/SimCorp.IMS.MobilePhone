using System;
using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public class MessageFormats {
        public delegate string FormatDelegate(StringBuilder combinedMessage);

        public static string WithoutFormatting(StringBuilder combinedMessage) {
            return combinedMessage.ToString();
        }

    }
}
