using System.Text;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public interface IReceiver {
        void OnSMSReceived(StringBuilder combinedMessagee);
    }
}
