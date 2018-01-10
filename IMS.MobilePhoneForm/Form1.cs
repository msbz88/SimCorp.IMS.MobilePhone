using Simcorp.IMS.MobilePhone.ClassLibrary.Headset;
using Simcorp.IMS.MobilePhone.ClassLibrary.Speaker;
using System;
using System.Windows.Forms;

namespace IMS.MobilePhoneForm {
    public partial class FormPlayComponents : Form {
        public FormPlayComponents() {
            InitializeComponent();
        }

        PhoneSpeaker Speaker = new PhoneSpeaker(1500);
        SamsungHeadset SamsungHeadset = new SamsungHeadset(300);
        IPhoneHeadset IPhoneHeadset = new IPhoneHeadset(350);

        private void Label1Click(object sender, EventArgs e) {

        }

        private void TextBox1TextOutput(object sender, EventArgs e) {

        }

        private void Panel2Paint(object sender, PaintEventArgs e) {

        }

        private void RadioButton1CheckedChanged(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                textBox1.Text = Speaker.ToString();
            }
        }

        private void RadioButton2CheckedChanged(object sender, EventArgs e) {
            if (radioButton2.Checked) {
                textBox1.Text = SamsungHeadset.ToString();
            }
        }

        private void RadioButton3CheckedChanged(object sender, EventArgs e) {
            if (radioButton3.Checked) {
                textBox1.Text = IPhoneHeadset.ToString();
            }
        }
    }
}
