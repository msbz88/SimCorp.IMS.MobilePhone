using Simcorp.IMS.MobilePhone.ClassLibrary.Contacts;
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
            foreach (Call call in calls) {
                listViewCalls.Items.Add(new ListViewItem(new[] {
                    call.Contact.ContactName, call.CountTimesCalled.ToString(),
                    call.Contact.MobileNumber.ToString(), call.ReceivedTime.ToString(), call.CallDirection }));
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
