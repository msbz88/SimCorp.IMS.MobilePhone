using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public partial class FormMessageFormating : Form {
        private SMSProvider.FormatDelegate Formatter = new SMSProvider.FormatDelegate(SMSProvider.FormateNone);
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
            OnSMSReceived("Message #" + MessageId + " received");
        }

        private void OnSMSReceived(string message) {
            if (InvokeRequired) {
                Invoke(new SMSProvider.SMSRecievedDelegate(OnSMSReceived), message);
                return;
            }
            string formattedMessage = Formatter($"{message}") + Environment.NewLine;
            richTextBoxMessages.AppendText(formattedMessage);
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
            switch (comboBoxFormattingOpt.Text) {
                case "No Formatting":
                    Formatter += SMSProvider.FormateNone;
                    break;
                case "Format with Time Before":
                    Formatter += SMSProvider.FormatWithTimeBefore;
                    break;
                case "Format with Time After":
                    Formatter += SMSProvider.FormatWithTimeAfter;
                    break;
                case "Format with UpperCase":
                    Formatter += SMSProvider.FormatWithUpperCase;
                    break;
                case "Format with LowerCase":
                    Formatter += SMSProvider.FormatWithLowerCase;
                    break;
                case "Format with Smile":
                    Formatter += SMSProvider.FormatWithSmile;
                    break;
            }
        }
    }
}
