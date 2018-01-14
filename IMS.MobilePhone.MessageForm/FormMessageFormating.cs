using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public partial class FormMessageFormating : Form {
        private readonly SMSProvider.FormatDelegate Formatter = new SMSProvider.FormatDelegate(SMSProvider.FormatWithTimeBefore);
        private static Timer messageTimer;
        private static int MessageId { get; set; }

        public FormMessageFormating(int interval) {
            InitializeComponent();
            InitializeComboBox();
            messageTimer = new Timer();
            messageTimer.Tick += new EventHandler(TimerTick);
            messageTimer.Interval = interval;
            messageTimer.Enabled = true;
        }

        private void TimerTick(object sender, EventArgs e) {
            MessageId++;
            OnSMSReceived("Message #" + MessageId);
        }

        private void OnSMSReceived(string message) {
            if (InvokeRequired) {
                Invoke(new SMSProvider.SMSRecievedDelegate(OnSMSReceived), message);
                return;
            }
            string formattedMessage = Formatter($"{message}{Environment.NewLine}");
            richTextBoxMessages.AppendText(formattedMessage);
        }

        private void InitializeComboBox() {
            string[] formattingOptions = new string[5];
            formattingOptions[0] = "Format with Time Before";
            formattingOptions[1] = "Format with Time After";
            formattingOptions[2] = "Format with UpperCase";
            formattingOptions[3] = "Format with LowerCase";
            formattingOptions[4] = "Format with Smile";
            comboBox1.Items.AddRange(formattingOptions);
        }
    }
}
