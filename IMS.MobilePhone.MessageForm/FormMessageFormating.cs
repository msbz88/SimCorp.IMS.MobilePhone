using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;
using System.Windows.Forms;
using System.Text;
using Simcorp.IMS.MobilePhone.MessageForm;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public partial class FormMessageFormating : Form, IReceiver {
        public MessageFormats.FormatDelegate Formatter = new MessageFormats.FormatDelegate(MessageFormats.WithoutFormatting);
        public string FormattedMessage {get; set;}

        public FormMessageFormating() {
            InitializeComponent();
            InitializeComboBox();
        }

        private void StripMenuCreateNewMessage(object sender, EventArgs e) {
            NewMessageForm newMessageForm = new NewMessageForm(this);
        }

        public void OnSMSReceived(StringBuilder combinedMessagee) {
            if (InvokeRequired) {
                Invoke(new SMSProvider.SMSRecievedDelegate(OnSMSReceived), combinedMessagee);
                return;
            }
            FormattedMessage = Formatter(combinedMessagee);
            WriteMessageToForm();
        }

        private void WriteMessageToForm() {
            richTextBoxMessages.AppendText(FormattedMessage);
            richTextBoxMessages.AppendText(Environment.NewLine);
            richTextBoxMessages.ScrollToCaret();
        }

        private void InitializeComboBox() {
            string[] formattingOptions = new string[6];
            formattingOptions[0] = "Without Formatting";
            formattingOptions[1] = "Format with Time Before";
            formattingOptions[2] = "Format with Time After";
            formattingOptions[3] = "Format with UpperCase";
            formattingOptions[4] = "Format with LowerCase";
            formattingOptions[5] = "Format with Smile";
            comboBoxFormattingOpt.Items.AddRange(formattingOptions);
        }

        private void ComboBox1SelectedIndexChanged(object sender, EventArgs e) {
            switch (comboBoxFormattingOpt.SelectedIndex) {
                case 0:
                    Formatter += MessageFormats.WithoutFormatting;
                    break;
                //case 1:
                //    Formatter += SMSProvider.FormatWithTimeBefore;
                //    break;
                //case 2:
                //    Formatter += SMSProvider.FormatWithTimeAfter;
                //    break;
                //case 3:
                //    Formatter += SMSProvider.FormatWithUpperCase;
                //    break;
                //case 4:
                //    Formatter += SMSProvider.FormatWithLowerCase;
                //    break;
                //case 5:
                //    Formatter += SMSProvider.FormatWithSmile;
                //    break;
            }
        }
    }
}
