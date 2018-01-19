using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Simcorp.IMS.MobilePhone.ClassLibrary.Storage.MobileStorage;
using static Simcorp.IMS.MobilePhone.MessageForm.MessagesFilters;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public partial class FormMessageFormating : Form, IReceiver {
        public MessageFormats.FormatDelegate Formatter = new MessageFormats.FormatDelegate(MessageFormats.WithoutFormatting);
        public string FormattedMessage { get; set; }
        private List<TextMessage> queryMessages = new List<TextMessage>();

        public FormMessageFormating() {
            InitializeComponent();
            InitializeComboBoxFormatting();
            OnMessageAdded += NotifyMessageAdded;
            OnMessageDeleted += NotifyMessageRemoved;
        }

        private void StripMenuCreateNewMessage(object sender, EventArgs e) {
            NewMessageForm newMessageForm = new NewMessageForm(this);
        }

        public void OnSMSReceived(TextMessage message) {
            if (InvokeRequired) {
                Invoke(new SMSProvider.SMSRecievedDelegate(OnSMSReceived), message);
                return;
            }
            InitializeComboBoxUsers();
            FormattedMessage = Formatter(message);
            WriteDetailedMessageToForm(FormattedMessage);
            WriteQuickMessageToForm(Messages);
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
            comboBoxUniqueUsers.Items.AddRange(Messages.Select(message => message.User).Distinct().ToArray());
            comboBoxUniqueUsers.SelectedIndex = 0;
        }

        private void ComboBoxUsersIndexChanged(object sender, EventArgs e) {
            if (CheckBoxOr1.Checked && textBoxMessageSearch.Text != "" && comboBoxUniqueUsers.Text != "All" && textBoxMessageSearch.Text != "") {
                queryMessages = GetMessagesUserOrContentAndDate(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            } else if (CheckBoxOr2.Checked && comboBoxUniqueUsers.Text != "All") {
                queryMessages = GetMessagesUserAndContentOrDate(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            } else if (CheckBoxOr2.Checked && comboBoxUniqueUsers.Text != "All" && textBoxMessageSearch.Text == "") {
                queryMessages = GetMessagesUserOrDate(Messages, comboBoxUniqueUsers.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            } else if (comboBoxUniqueUsers.Text == "All" && textBoxMessageSearch.Text == "") {
                CheckBoxOr1.Enabled = false;
                WriteQuickMessageToForm(Messages);
            } else if (textBoxMessageSearch.Text != "") {
                queryMessages = GetMessagesUserAndContentAndDate(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            } else {
                WriteQuickMessageToForm(GetMessagesUser(Messages, comboBoxUniqueUsers.Text));
            }
        }

        private void TextBoxMessageSearchTextChanged(object sender, EventArgs e) {
            if (CheckBoxOr1.Checked && textBoxMessageSearch.Text != "" && comboBoxUniqueUsers.Text != "All" && textBoxMessageSearch.Text != "") {
                queryMessages = GetMessagesUserOrContentAndDate(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            } else if (CheckBoxOr2.Checked && comboBoxUniqueUsers.Text != "All" && textBoxMessageSearch.Text != "") {
                queryMessages = GetMessagesUserAndContentOrDate(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            } else if (CheckBoxOr2.Checked && comboBoxUniqueUsers.Text == "All" && textBoxMessageSearch.Text != "") {
                queryMessages = GetMessagesContentOrDate(Messages, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            } else if (comboBoxUniqueUsers.Text == "All" && textBoxMessageSearch.Text == "") {
                CheckBoxOr1.Enabled = false;
                WriteQuickMessageToForm(GetMessagesDate(Messages, dateTimePickerFrom.Value, dateTimePickerTo.Value));
            } else if (comboBoxUniqueUsers.Text == "All" && textBoxMessageSearch.Text != "") {
                CheckBoxOr1.Enabled = false;
                queryMessages = GetMessagesContentAndDate(Messages, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            } else {
                queryMessages = GetMessagesUserAndContentAndDate(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            }
        }

        private void DateTimePickerFromValueChanged(object sender, EventArgs e) {
            if (comboBoxUniqueUsers.Text == "All" && textBoxMessageSearch.Text == "") {
                CheckBoxOr1.Enabled = false;
                WriteQuickMessageToForm(GetMessagesDate(Messages, dateTimePickerFrom.Value, dateTimePickerTo.Value));
            } else if (CheckBoxOr2.Checked && comboBoxUniqueUsers.Text != "All" && textBoxMessageSearch.Text != "") {
                queryMessages = GetMessagesUserAndContentOrDate(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            } else if (CheckBoxOr2.Checked && comboBoxUniqueUsers.Text != "All" && textBoxMessageSearch.Text == "") {
                queryMessages = GetMessagesUserOrDate(Messages, comboBoxUniqueUsers.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            } else if (CheckBoxOr2.Checked && comboBoxUniqueUsers.Text == "All" && textBoxMessageSearch.Text != "") {
                CheckBoxOr1.Enabled = false;
                queryMessages = GetMessagesContentOrDate(Messages, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            } else {
                queryMessages = GetMessagesUserAndContentAndDate(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            }
        }

        private void DateTimePickerToValueChanged(object sender, EventArgs e) {
            if (comboBoxUniqueUsers.Text == "All" && textBoxMessageSearch.Text == "") {
                CheckBoxOr1.Enabled = false;
                WriteQuickMessageToForm(GetMessagesDate(Messages, dateTimePickerFrom.Value, dateTimePickerTo.Value));
            } else if (CheckBoxOr2.Checked && comboBoxUniqueUsers.Text != "All" && textBoxMessageSearch.Text != "") {
                queryMessages = GetMessagesUserAndContentOrDate(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            } else if (CheckBoxOr2.Checked && comboBoxUniqueUsers.Text != "All" && textBoxMessageSearch.Text == "") {
                queryMessages = GetMessagesUserOrDate(Messages, comboBoxUniqueUsers.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            } else if (CheckBoxOr2.Checked && comboBoxUniqueUsers.Text == "All" && textBoxMessageSearch.Text != "") {
                CheckBoxOr1.Enabled = false;
                queryMessages = GetMessagesContentOrDate(Messages, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            } else {
                queryMessages = GetMessagesUserAndContentAndDate(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                WriteQuickMessageToForm(queryMessages);
            }
        }

        private void CheckBoxOr1Changed(object sender, EventArgs e) {
            if (CheckBoxOr1.Checked) {
                CheckBoxOr2.Enabled = false;
            } else { CheckBoxOr2.Enabled = true; }
        }

        private void CheckBoxOr2Changed(object sender, EventArgs e) {
            if (CheckBoxOr2.Checked) {
                CheckBoxOr1.Enabled = false;
            } else { CheckBoxOr1.Enabled = true; }
        }
    }
}
