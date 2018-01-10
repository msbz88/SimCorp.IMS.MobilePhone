using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simcorp.IMS.MobilePhone.ClassLibrary.Speaker;
using Simcorp.IMS.MobilePhone.ClassLibrary.Headset;

namespace IMS.MobilePhoneForm {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPlayComponents());
        }
    }
}
