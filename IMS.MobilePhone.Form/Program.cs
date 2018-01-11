using IMS.MobilePhoneForm.Output;
using Simcorp.IMS.MobilePhone.ClassLibrary.Headset;
using Simcorp.IMS.MobilePhone.ClassLibrary.Speaker;
using System;
using System.Windows.Forms;

namespace IMS.MobilePhoneForm {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormPlayComponents formPlayComponents = new FormPlayComponents();
            PhoneSpeaker speaker = new PhoneSpeaker(1000, new FormOutput(formPlayComponents));
            SamsungHeadset samsungHeadset = new SamsungHeadset(300, new FormOutput(formPlayComponents));
            IPhoneHeadset iPhoneHeadset = new IPhoneHeadset(350, new FormOutput(formPlayComponents));
            formPlayComponents.Speaker = speaker;
            formPlayComponents.SamsungHeadset = samsungHeadset;
            formPlayComponents.IPhoneHeadset = iPhoneHeadset;
            Application.Run(formPlayComponents);
        }
    }
}
