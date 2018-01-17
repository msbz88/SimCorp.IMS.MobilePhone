using Simcorp.IMS.MobilePhone.ClassLibrary.Storage;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public class SMSProvider {
        public delegate void SMSRecievedDelegate(TextMessage message);
        public event SMSRecievedDelegate SMSRecieved;
        IReceiver Receiver { get; set; }

        public SMSProvider(IReceiver receiver) {
            this.Receiver = receiver;
        }

        public void RaiseSMSReceivedEvent(TextMessage message) {
            SMSRecieved?.Invoke(message);
        }

        public void SendMessage(TextMessage message) {
            Receiver.OnSMSReceived(message);
            MobileStorage.AddMessage(message);
        }
    }
}
