using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public partial class FormMessageFormating : Form, IReceiver {
        public MessageFormats.FormatDelegate Formatter = new MessageFormats.FormatDelegate(MessageFormats.WithoutFormatting);
        public string FormattedMessage { get; set; }
        public List<TextMessage> Storage = new List<TextMessage>();

        public FormMessageFormating() {
            InitializeComponent();
            InitializeComboBoxFormatting();
        }

        private void StripMenuCreateNewMessage(object sender, EventArgs e) {
            NewMessageForm newMessageForm = new NewMessageForm(this);
        }

        public void OnSMSReceived(TextMessage message) {
            if (InvokeRequired) {
                Invoke(new SMSProvider.SMSRecievedDelegate(OnSMSReceived), message);
                return;
            }
            Storage.Add(message);
            FormattedMessage = Formatter(message);
            WriteMessageToForm();
            ShowMessages(Storage);
            InitializeComboBoxUsers();
        }

        private void ShowMessages(List<TextMessage> messages) {
            listViewMessages.Items.Clear();
            foreach (TextMessage message in messages) {
                listViewMessages.Items.Add(new ListViewItem(new[] { message.User, message.Text }));
            }
            listViewMessages.Items[listViewMessages.Items.Count - 1].EnsureVisible();
        }

        private void WriteMessageToForm() {
            richTextBoxMessages.AppendText(FormattedMessage);
            richTextBoxMessages.AppendText(Environment.NewLine);
            richTextBoxMessages.ScrollToCaret();
        }

        private void InitializeComboBoxFormatting() {
            string[] formattingOptions = new string[5];
            formattingOptions[0] = "Without Formatting (default)";
            formattingOptions[1] = "Received time at the beginning";
            formattingOptions[2] = "Upper message text";
            formattingOptions[3] = "Upper User Name and received time";
            formattingOptions[4] = "Lower message text";
            comboBoxFormattingOpt.Items.AddRange(formattingOptions);
        }

        private void ComboBoxFormattingIndexChanged(object sender, EventArgs e) {
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

        private void InitializeComboBoxUsers() {
            comboBoxUniqueUsers.Items.Clear();
            comboBoxUniqueUsers.Items.AddRange(Storage.Select(message => message.User).Distinct().ToArray());
        }

        private void ComboBoxUsersIndexChanged(object sender, EventArgs e) {

        }

        private void TextBoxMessageSearchTextChanged(object sender, EventArgs e) {

        }
    }
}
