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

        public void OnSMSReceived(TextMessage message) {
            if (InvokeRequired) {
                Invoke(new SMSProvider.SMSRecievedDelegate(OnSMSReceived), message);
                return;
            }
            FormattedMessage = Formatter(message);
            WriteMessageToForm();
        }

        private void WriteMessageToForm() {
            richTextBoxMessages.AppendText(FormattedMessage);
            richTextBoxMessages.AppendText(Environment.NewLine);
            richTextBoxMessages.ScrollToCaret();
        }

        private void InitializeComboBox() {
            string[] formattingOptions = new string[5];
            formattingOptions[0] = "Without Formatting (default)";
            formattingOptions[1] = "Received time at the beginning";
            formattingOptions[2] = "Upper message text";
            formattingOptions[3] = "Upper User Name and received time";
            formattingOptions[4] = "Lower message text";
            comboBoxFormattingOpt.Items.AddRange(formattingOptions);
        }

        private void ComboBox1SelectedIndexChanged(object sender, EventArgs e) {
            switch (comboBoxFormattingOpt.SelectedIndex) {
                case 0:
                    Formatter += MessageFormats.WithoutFormatting;
                    break;
                case 1:
                    Formatter += MessageFormats.BeginWithTimeFormatting;
                    break;
                case 2:
                    Formatter += MessageFormats.UpperMessageTextFormatting;
                    break;
                case 3:
                    Formatter += MessageFormats.UpperMessageUserAndTimeFormatting;
                    break;
                case 4:
                    Formatter += MessageFormats.LowerMessageTextFormatting;
                    break;
            }
        }
    }
}
