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
            Application.Run(new FormMessageFormating(2000));
        }
    }
}
