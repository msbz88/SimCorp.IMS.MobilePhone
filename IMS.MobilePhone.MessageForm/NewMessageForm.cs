using Simcorp.IMS.MobilePhone.ClassLibrary.SMS;
using System;
using System.Linq;
using System.Windows.Forms;

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

        public static string RandomString(int length) {
            const string chars = "ABC";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void GenerateMessages(object sender, EventArgs e) {
            SMSProvider SMSProvider = new SMSProvider(FormMessageFormating);
            Message = new TextMessage(RandomString(3), RandomString(15));
            SMSProvider.SendMessage(Message);
        }

        private void ButtonStopMesssages(object sender, EventArgs e) {
            MyTimer.Stop();
        }
    }
}
