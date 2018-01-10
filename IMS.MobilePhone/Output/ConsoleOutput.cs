using System;
using Simcorp.IMS.MobilePhone.ClassLibrary.API;

namespace Simcorp.IMS.MobilePhone.ConsoleApp.Output {
    class ConsoleOutput : IOutput{
        public void Write(string text) {
            Console.Write(text);
        }

        public void WriteLine(string text) {
            Console.WriteLine(text);
        }
    }
}
