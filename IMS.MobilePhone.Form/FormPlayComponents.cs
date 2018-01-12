using Simcorp.IMS.MobilePhone.ClassLibrary.Headset;
using Simcorp.IMS.MobilePhone.ClassLibrary.Speaker;
using System;
using System.Windows.Forms;

namespace Simcorp.IMS.MobilePhone.PlaybackForm {
    public partial class FormPlayComponents : Form {
        public PhoneSpeaker Speaker { get; set; }
        public SamsungHeadset SamsungHeadset { get; set; }
        public IPhoneHeadset IPhoneHeadset { get; set; }

        public FormPlayComponents() {
            InitializeComponent();
        }

        private void RadioButton1CheckedChanged(object sender, EventArgs e) {
            if (radioButton1.Checked) { 
                Speaker.Play();
            }
        }

        private void RadioButton2CheckedChanged(object sender, EventArgs e) {
            if (radioButton2.Checked) {
                SamsungHeadset.Play();
            }
        }

        private void RadioButton3CheckedChanged(object sender, EventArgs e) {
            if (radioButton3.Checked) {
                IPhoneHeadset.Play();
            }
        }
    }
}
