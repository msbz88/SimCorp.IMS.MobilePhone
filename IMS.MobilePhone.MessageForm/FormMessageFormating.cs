using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;
using System.Windows.Forms;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public partial class FormMessageFormating : Form {
        public SMSProvider.FormatDelegate Formatter = new SMSProvider.FormatDelegate(SMSProvider.FormateNone);
        private static Timer messageTimer;
        public string FormattedMessage {get; set;}

        public FormMessageFormating() {
            InitializeComponent();
            InitializeComboBox();
        }

        public void GenerateMessages(bool enableTimer, int intervalTimer) {
            messageTimer = new Timer();
            messageTimer.Tick += new EventHandler(ProcessMessage);
            messageTimer.Interval = intervalTimer;
            messageTimer.Enabled = enableTimer;
        }

        private void ProcessMessage(object sender, EventArgs e) {
            OnSMSReceived(SMSProvider.SendMessage());
            WriteMessageToForm();
        }

        public void OnSMSReceived(string message) {
            if (InvokeRequired) {
                Invoke(new SMSProvider.SMSRecievedDelegate(OnSMSReceived), message);
                return;
            }
            FormattedMessage = Formatter($"{message}");
        }

        private void WriteMessageToForm() {
            richTextBoxMessages.AppendText(FormattedMessage + Environment.NewLine);
            richTextBoxMessages.ScrollToCaret();
        }

        private void InitializeComboBox() {
            string[] formattingOptions = new string[6];
            formattingOptions[0] = "No Formatting";
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
                    Formatter += SMSProvider.FormateNone;
                    break;
                case 1:
                    Formatter += SMSProvider.FormatWithTimeBefore;
                    break;
                case 2:
                    Formatter += SMSProvider.FormatWithTimeAfter;
                    break;
                case 3:
                    Formatter += SMSProvider.FormatWithUpperCase;
                    break;
                case 4:
                    Formatter += SMSProvider.FormatWithLowerCase;
                    break;
                case 5:
                    Formatter += SMSProvider.FormatWithSmile;
                    break;
            }
        }
    }
}
