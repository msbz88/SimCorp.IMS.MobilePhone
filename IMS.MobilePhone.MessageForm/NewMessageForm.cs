using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;
using System.Windows.Forms;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public partial class NewMessageForm : Form {
        TextMessage Message { get; set; }
        FormMessageFormating FormMessageFormating { get; set; }
        MessageGenThread MessageGenThread { get; set; }

        public NewMessageForm(FormMessageFormating formMessageFormating) {
            this.FormMessageFormating = formMessageFormating;
            InitializeComponent();
            this.Show();
            richTextBoxNewMessage.ScrollToCaret();
            MessageGenThread = new MessageGenThread(formMessageFormating);
        }

        private void ButtonSendMessage(object sender, EventArgs e) {
            if (textBox1.Text == "") {
                MessageBox.Show("Please write your name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (richTextBoxNewMessage.Text == "") {
                MessageBox.Show("Oops! You forgot to type your message!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                SMSProvider SMSProvider = new SMSProvider(FormMessageFormating);
                Message = new TextMessage(textBox1.Text, richTextBoxNewMessage.Text);
                SMSProvider.SendMessage(Message);
                richTextBoxNewMessage.Clear();
                richTextBoxNewMessage.Focus();
            }
        }

        private void ButtonGenerateMessages(object sender, EventArgs e) {
            MessageGenThread.StartThread();
        }

        private void ButtonStopMesssages(object sender, EventArgs e) {
            MessageGenThread.StopThread();
        }
    }
}
