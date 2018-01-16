using System;
using System.Text;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public class SMSProvider {
        public delegate void SMSRecievedDelegate(StringBuilder combinedMessagee);
        public event SMSRecievedDelegate SMSRecieved;

        IReceiver Receiver { get; set; }

        public SMSProvider(IReceiver receiver) {
            this.Receiver = receiver;
        }

        public void RaiseSMSReceivedEvent(StringBuilder combinedMessagee) {
            SMSRecieved?.Invoke(combinedMessagee);
        }

        public void SendMessage(Message message) {
            StringBuilder combinedMessage = new StringBuilder();
            Delegate allMessageComponents = message.CombineMessageComponents();
            foreach (Delegate messageComponent in allMessageComponents.GetInvocationList()) {
                combinedMessage.Append(messageComponent.DynamicInvoke() + "\n");
            }
            Receiver.OnSMSReceived(combinedMessage);
        }
    }
}
