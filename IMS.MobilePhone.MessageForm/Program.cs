using System;
using System.Windows.Forms;

namespace Simcorp.IMS.MobilePhone.MessageForm {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMessageFormating formMessageFormating = new FormMessageFormating();
            formMessageFormating.GenerateMessages(true, 2000);
            Application.Run(formMessageFormating);

        }
    }
}
