using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    public partial class NewMessageForm : Form {
        TextMessage Message { get; set; }
        FormMessageFormating FormMessageFormating { get; set; }
        static Timer MyTimer = new Timer();
        private static Random random = new Random();

        public NewMessageForm(FormMessageFormating formMessageFormating) {
            this.FormMessageFormating = formMessageFormating;
            InitializeComponent();
            this.Show();
            richTextBoxNewMessage.ScrollToCaret();
            InitializeTimer(3000);
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
            List<string> userPhrases = new List<string> { "Hello!", "Hi!", "How are u?", "Bye", "How do you like Japan so far?",
                "See you this weekend!" , "In my view, it's a difficult task.", "What do you think?", "What a wonderful day!",
                "You did it!", "Well done!", "Don't get upset.", "Let's go to a football game.", "Why don't we go to a concert?",
                "Why do you ask?", "Nice morning today, isn't it?", "Do you agree?" };
            int index = random.Next(userPhrases.Count);
            string curPhrase = userPhrases[index];
            userPhrases.RemoveAt(index);
            return curPhrase;
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
