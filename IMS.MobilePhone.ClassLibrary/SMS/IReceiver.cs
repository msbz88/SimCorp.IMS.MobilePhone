namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public interface IReceiver {
        void OnSMSReceived(TextMessage message);
    }
}
