using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public partial class NewMessageForm : Form {
        TextMessage Message { get; set; }
        FormMessageFormating FormMessageFormating { get; set; }
        Timer MyTimer = new Timer();
        private static Random random = new Random();

        public NewMessageForm(FormMessageFormating formMessageFormating) {
            this.FormMessageFormating = formMessageFormating;
            InitializeComponent();
            this.Show();
            richTextBoxNewMessage.ScrollToCaret();
            InitializeTimer(3000);
        }

        private void ButtonSendMessage(object sender, EventArgs e) {
            SMSProvider SMSProvider = new SMSProvider(FormMessageFormating);
            Message = new TextMessage(textBox1.Text, richTextBoxNewMessage.Text);
            SMSProvider.SendMessage(Message);
            richTextBoxNewMessage.Clear();
            richTextBoxNewMessage.Focus();
        }

        private void ButtonGenerateMessages(object sender, EventArgs e) {
            MyTimer.Start();
        }

        private void InitializeTimer(int interval) {
            MyTimer.Interval = (interval);
            MyTimer.Tick += new EventHandler(GenerateMessages);
        }

        private static string RandomName() {
            List<string> userNames = new List<string> { "John", "Sam", "Rob", "Martin", "Julia", "Eva" };
            int index = random.Next(userNames.Count);
            string curName = userNames[index];
            userNames.RemoveAt(index);
            return curName;
        }

        private static string RandomMessage() {
            List<string> userNames = new List<string> { "Hello!", "Hi!", "How are u?", "Bye", "How do you like Japan so far?", "See you this weekend!" };
            int index = random.Next(userNames.Count);
            string curName = userNames[index];
            userNames.RemoveAt(index);
            return curName;
        }

        private void GenerateMessages(object sender, EventArgs e) {
            SMSProvider SMSProvider = new SMSProvider(FormMessageFormating);
            Message = new TextMessage(RandomName(), RandomMessage());
            SMSProvider.SendMessage(Message);
        }

        private void ButtonStopMesssages(object sender, EventArgs e) {
            MyTimer.Stop();
        }
    }
}
