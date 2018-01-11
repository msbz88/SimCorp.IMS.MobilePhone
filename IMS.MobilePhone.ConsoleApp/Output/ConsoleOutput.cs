using System;
using Simcorp.IMS.MobilePhone.ClassLibrary.Output;

namespace Simcorp.IMS.MobilePhone.ConsoleApp.Output {
   public class ConsoleOutput : IOutput{
        public void Write(string text) {
            Console.Write(text);
        }

        public void WriteLine(string text) {
            Console.WriteLine(text);
        }
    }
}
