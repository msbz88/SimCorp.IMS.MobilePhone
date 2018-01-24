using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Simcorp.IMS.MobilePhone.ClassLibrary.Storage.MobileStorage;
using Simcorp.IMS.MobilePhone.ClassLibrary.Battery;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public partial class FormMessageFormating : Form, IReceiver {
        public MessageFormats.FormatDelegate Formatter = new MessageFormats.FormatDelegate(MessageFormats.WithoutFormatting);
        public string FormattedMessage { get; set; }
        private List<TextMessage> queryMessages = new List<TextMessage>();
        LithiumLonBattery LithiumLonBattery { get; set; }
        ChargeBase BatteryCharger { get; set; }
        private bool Battery10Charge { get; set; } = true;
        NewMessageForm NewMessageForm { get; set; }

        public FormMessageFormating() {
            InitializeComponent();
            InitializeComboBoxFormatting();
            OnMessageAdded += NotifyMessageAdded;
            OnMessageDeleted += NotifyMessageRemoved;
            BatteryBase.OnChargeChanged += DisplayCharge;
           // BatteryBase.OnCharge10 += LowBatteryNotification;
            InitializeComboBoxUsers();
            LithiumLonBattery = new LithiumLonBattery(4000);
            Factory();
        }

        private void StripMenuCreateNewMessage(object sender, EventArgs e) {
            if (NewMessageForm == null) {
                NewMessageForm = new NewMessageForm(this);
            } else { NewMessageForm.Activate(); }
        }

        public void OnSMSReceived(TextMessage message) {
            if (InvokeRequired) {
                Invoke(new SMSProvider.SMSRecievedDelegate(OnSMSReceived), message);
                return;
            }
            UpdateComboBoxUsers();
            UpdateQuickMessageView();
            FormattedMessage = Formatter(message);
            WriteDetailedMessageToForm(FormattedMessage);
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

        private void UpdateComboBoxUsers() {
            string remmemberContact = comboBoxUniqueUsers.Text;
            comboBoxUniqueUsers.Items.Clear();
            comboBoxUniqueUsers.Items.Add("All");
            comboBoxUniqueUsers.Items.AddRange(Messages.Select(message => message.User).Distinct().ToArray());
            comboBoxUniqueUsers.Text = remmemberContact;
        }

        private void UpdateQuickMessageView() {
            queryMessages = Filters(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value, CheckBoxOr1.Checked, CheckBoxOr2.Checked);
            WriteQuickMessageToForm(queryMessages);
        }

        public List<TextMessage> Filters(List<TextMessage> messages, string user, string search, DateTime dateFrom, DateTime dateTo, bool checkOr1, bool checkOr2) {
            if (user == "All") {
                CheckBoxOr1.Enabled = false;
            } else { CheckBoxOr1.Enabled = true; }
            //And conditions
            if (user != "All" && search != "" && checkOr1 == false && checkOr2 == false) {
                return messages.Where(message => message.User == user && message.Text.Contains(search) && (message.ReceivinigTime.Date >= dateFrom.Date && message.ReceivinigTime.Date <= dateTo.Date)).ToList();
            } else if (user == "All" && search != "" && checkOr1 == false && checkOr2 == false) {
                return messages.Where(message => message.Text.Contains(search) && (message.ReceivinigTime.Date >= dateFrom.Date && message.ReceivinigTime.Date <= dateTo.Date)).ToList();
            } else if (user != "All" && search == "" && checkOr1 == false && checkOr2 == false) {
                return messages.Where(message => message.User == user && (message.ReceivinigTime.Date >= dateFrom.Date && message.ReceivinigTime.Date <= dateTo.Date)).ToList();
            } else if (user != "All" && search == "" && checkOr1 == true && checkOr2 == false) {
                return messages.Where(message => message.User == user && (message.ReceivinigTime.Date >= dateFrom.Date && message.ReceivinigTime.Date <= dateTo.Date)).ToList();
            } else if (user == "All" && search == "" && checkOr1 == false && checkOr2 == false) {
                return messages.Where(message => message.ReceivinigTime.Date >= dateFrom.Date && message.ReceivinigTime.Date <= dateTo.Date).ToList();
            }
            //Or conditions
              else if (user != "All" && search != "" && checkOr1 == true && checkOr2 == true) {
                return messages.Where(message => message.User == user || message.Text.Contains(search) || (message.ReceivinigTime.Date >= dateFrom.Date && message.ReceivinigTime.Date <= dateTo.Date)).ToList();
            } else if (user == "All" && search != "" && checkOr1 == false && checkOr2 == true) {
                return messages.Where(message => message.Text.Contains(search) || (message.ReceivinigTime.Date >= dateFrom.Date && message.ReceivinigTime.Date <= dateTo.Date)).ToList();
            } else if (user != "All" && search != "" && checkOr1 == true && checkOr2 == false) {
                return messages.Where(message => message.User == user || message.Text.Contains(search) && (message.ReceivinigTime.Date >= dateFrom.Date && message.ReceivinigTime.Date <= dateTo.Date)).ToList();
            } else if (user != "All" && search == "" && checkOr1 == false && checkOr2 == true) {
                return messages.Where(message => message.User == user || (message.ReceivinigTime.Date >= dateFrom.Date && message.ReceivinigTime.Date <= dateTo.Date)).ToList();
            }else {
                return messages.ToList();
            }
        }

        private void ComboBoxUsersIndexChanged(object sender, EventArgs e) {
            queryMessages = Filters(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value, CheckBoxOr1.Checked, CheckBoxOr2.Checked);
            WriteQuickMessageToForm(queryMessages);
        }

        private void TextBoxMessageSearchTextChanged(object sender, EventArgs e) {
            queryMessages = Filters(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value, CheckBoxOr1.Checked, CheckBoxOr2.Checked);
            WriteQuickMessageToForm(queryMessages);
        }

        private void DateTimePickerFromValueChanged(object sender, EventArgs e) {
            queryMessages = Filters(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value, CheckBoxOr1.Checked, CheckBoxOr2.Checked);
            WriteQuickMessageToForm(queryMessages);
        }

        private void DateTimePickerToValueChanged(object sender, EventArgs e) {
            queryMessages = Filters(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value, CheckBoxOr1.Checked, CheckBoxOr2.Checked);
            WriteQuickMessageToForm(queryMessages);
        }

        private void CheckBoxOr1Changed(object sender, EventArgs e) {
            queryMessages = Filters(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value, CheckBoxOr1.Checked, CheckBoxOr2.Checked);
            WriteQuickMessageToForm(queryMessages);
        }

        private void CheckBoxOr2Changed(object sender, EventArgs e) {
            queryMessages = Filters(Messages, comboBoxUniqueUsers.Text, textBoxMessageSearch.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value, CheckBoxOr1.Checked, CheckBoxOr2.Checked);
            WriteQuickMessageToForm(queryMessages);
        }

        private void DisplayCharge() {
            progressBarCharge.Value = (int)(LithiumLonBattery.GetBatteryChargeLevel() * 100);
        }

        private void Factory() {
            ChargeBaseFactory[] chargeFactory = new ChargeBaseFactory[2];
            chargeFactory[0] = new ChargeThreadFactory(LithiumLonBattery);
            chargeFactory[1] = new ChargeTaskFactory(LithiumLonBattery);
            BatteryCharger = chargeFactory[1].FactoryMethod();
        }

        private void ButtonChargeClick(object sender, EventArgs e) {
            BatteryCharger.StartCharge();
            Battery10Charge = false;
        }

        private void ButtonStopChargeClick(object sender, EventArgs e) {
            BatteryCharger.StopCharge();
            Battery10Charge = true;
        }

        private void LowBatteryNotification() {
            if ((int)(LithiumLonBattery.GetBatteryChargeLevel() * 100) <10 && Battery10Charge) {
                MessageBox.Show("Low charge level! Please charge battery.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
