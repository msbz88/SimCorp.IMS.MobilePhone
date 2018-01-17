using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;
using System.Windows.Forms;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public partial class NewMessageForm : Form {
        TextMessage Message { get; set; }
        FormMessageFormating FormMessageFormating { get; set; }

        public NewMessageForm(FormMessageFormating formMessageFormating) {
            this.FormMessageFormating = formMessageFormating;
            InitializeComponent();
            this.Show();
            richTextBoxNewMessage.ScrollToCaret();
        }

        private void ButtonSendMessage(object sender, EventArgs e) {
            Message = new TextMessage(textBox1.Text, richTextBoxNewMessage.Text);
            SMSProvider SMSProvider = new SMSProvider(FormMessageFormating);
            SMSProvider.SendMessage(Message);
            richTextBoxNewMessage.Clear();
            richTextBoxNewMessage.Focus();
        }
    }
}
