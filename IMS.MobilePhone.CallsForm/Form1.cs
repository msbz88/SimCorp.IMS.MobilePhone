using Simcorp.IMS.MobilePhone.ClassLibrary.Contact;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simcorp.IMS.MobilePhone.CallsForm {
    public partial class FormCalls : Form {
        CallsGenThread CallsGenThread { get; set; }

        public FormCalls() {
            InitializeComponent();
            CallsGenThread = new CallsGenThread();
            CallsGenThread.OnNewCallAdded += WriteCallsToForm;
        }

        private void WriteCallsToForm(List<Call> calls) {
            listViewCalls.Items.Clear();
            foreach (Call c in calls) {
                listViewCalls.Items.Add(new ListViewItem(new[] { c.Contact.ContactName, c.Contact.MobileNumber.ToString(), c.ReceivedTime.ToString(), c.CallDirection }));
            }
        }

        private void ButtonStartClick(object sender, EventArgs e) {
            CallsGenThread.StartGeneration();
        }

        private void ButtonStopClick(object sender, EventArgs e) {
            CallsGenThread.StopGeneration();
        }
    }
}
