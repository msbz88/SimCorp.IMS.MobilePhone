using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;
using System.Windows.Forms;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public partial class NewMessageForm : Form {
        SMSProvider SMSProvider { get; set; }
        TextMessage Message { get; set; }
        MessageGenTask MessageGenTask { get; set; }
        FormMessageFormating FormMessageFormating { get; set; }
        public MessageGenBase MessageGen { get; set; }

        public NewMessageForm(FormMessageFormating formMessageFormating) {
            FormMessageFormating = formMessageFormating;
            InitializeComponent();
            this.Show();
            richTextBoxNewMessage.ScrollToCaret();
            SMSProvider = new SMSProvider(formMessageFormating);
            Factory();
        }

        private void ButtonSendMessage(object sender, EventArgs e) {
            if (textBox1.Text == "") {
                MessageBox.Show("Please write your name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (richTextBoxNewMessage.Text == "") {
                MessageBox.Show("Oops! You forgot to type your message!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                Message = new TextMessage(textBox1.Text, richTextBoxNewMessage.Text);
                SMSProvider.SendMessage(Message);
                richTextBoxNewMessage.Clear();
                richTextBoxNewMessage.Focus();
            }
        }

        private void Factory() {
            MGenBaseFactory[] messagesFactory = new MGenBaseFactory[2];
            messagesFactory[0] = new MGenThreadFactory(FormMessageFormating);
            messagesFactory[1] = new MGenTaskFactory(FormMessageFormating);
            MessageGen = messagesFactory[0].FactoryMethod();
        }

        private void ButtonGenerateMessages(object sender, EventArgs e) {
            MessageGen.StartGeneration();
        }

        private void ButtonStopMesssages(object sender, EventArgs e) {
            MessageGen.StopGeneration();
        }
    }
}
