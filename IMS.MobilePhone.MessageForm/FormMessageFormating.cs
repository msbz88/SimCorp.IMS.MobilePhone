using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using Simcorp.IMS.MobilePhone.ClassLibrary.Storage;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public partial class FormMessageFormating : Form, IReceiver {
        public MessageFormats.FormatDelegate Formatter = new MessageFormats.FormatDelegate(MessageFormats.WithoutFormatting);
        public string FormattedMessage { get; set; }
        private List<TextMessage> queryMessages = new List<TextMessage>();

        public FormMessageFormating() {
            InitializeComponent();
            InitializeComboBoxFormatting();
            MobileStorage.OnMessageAdded += NotifyMessageAdded;
            MobileStorage.OnMessageDeleted += NotifyMessageRemoved;
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
            WriteDetailedMessageToForm(FormattedMessage);
            WriteQuickMessageToForm(MobileStorage.Messages);
            InitializeComboBoxUsers();
        }

        private void WriteQuickMessageToForm(List<TextMessage> messages) {
            listViewMessages.Items.Clear();
            foreach (TextMessage message in messages) {
                listViewMessages.Items.Add(new ListViewItem(new[] { message.User, message.Text }));
            }
            if (listViewMessages.Items.Count != 0) {
                listViewMessages.Items[listViewMessages.Items.Count - 1].EnsureVisible();
            }
        }

        private void WriteDetailedMessageToForm(string formattedMessage) {
            richTextBoxMessages.AppendText(formattedMessage);
            richTextBoxMessages.AppendText(Environment.NewLine);
            richTextBoxMessages.ScrollToCaret();
        }

        public string NotifyMessageAdded() {
            string notification = "System: Message saved.";
            WriteSystemNotificationsToForm(notification);
            return notification;
        }

        public string NotifyMessageRemoved() {
            string notification = "System: Message removed.";
            WriteSystemNotificationsToForm(notification);
            return notification;
        }

        private void WriteSystemNotificationsToForm(string message) {
            richTextBoxMessages.SelectionColor = Color.Gray;
            richTextBoxMessages.AppendText(message + "\n");
        }

        private void InitializeComboBoxFormatting() {
            List<string> formattingOptions = new List<string>();
            formattingOptions.Add("Without Formatting (default)");
            formattingOptions.Add("Received time at the beginning");
            formattingOptions.Add("Upper message text");
            formattingOptions.Add("Upper User Name and received time");
            formattingOptions.Add("Lower message text");
            comboBoxFormattingOpt.Items.AddRange(formattingOptions.ToArray());
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
            comboBoxUniqueUsers.Items.Add("All");
            comboBoxUniqueUsers.Items.AddRange(MobileStorage.Messages.Select(message => message.User).Distinct().ToArray());
        }

        private void ComboBoxUsersIndexChanged(object sender, EventArgs e) {
            if (comboBoxUniqueUsers.Text == "All") {
                WriteQuickMessageToForm(MobileStorage.Messages);
            } else {
                WriteQuickMessageToForm(MessagesFilters.GetAllMessagesOfUser(MobileStorage.Messages, comboBoxUniqueUsers.Text));
            }
        }

        private void TextBoxMessageSearchTextChanged(object sender, EventArgs e) {
            WriteQuickMessageToForm(MessagesFilters.GetMessagesByContent(MobileStorage.Messages, textBoxMessageSearch.Text));
        }

        private void DateTimePickerFromValueChanged(object sender, EventArgs e) {
            WriteQuickMessageToForm(MessagesFilters.GetMessagesBetweenDates(MobileStorage.Messages, dateTimePickerFrom.Value, dateTimePickerTo.Value));
        }

        private void DateTimePickerToValueChanged(object sender, EventArgs e) {
            WriteQuickMessageToForm(MessagesFilters.GetMessagesBetweenDates(MobileStorage.Messages, dateTimePickerFrom.Value, dateTimePickerTo.Value));
        }
    }
}
