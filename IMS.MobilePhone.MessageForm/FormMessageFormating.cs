using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System.Windows.Forms;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public partial class FormMessageFormating : Form {
        public FormMessageFormating() {
            InitializeComponent();
        }
        //private readonly FormatDelegate Formatter = new FormatDelegate(FormatWithTimeBefore);

        private void OnSMSReceived(string message) {
            if (InvokeRequired) {
                Invoke(new SMSProvider.SMSRecievedDelegate(OnSMSReceived), message);
                return;
            }

            //string formattedMessage = Formatter($"{message}{Environment.NewLine}");
            //textBox1.AppendText(formattedMessage);
        }
    }
}
