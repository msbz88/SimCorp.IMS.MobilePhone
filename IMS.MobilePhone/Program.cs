using System;
using Simcorp.IMS.MobilePhone.API;

namespace Simcorp.IMS.MobilePhone {
    class Program {
        static void Main(string[] args) {
            SimCorpMobile simMobile = new SimCorpMobile();
            Console.WriteLine(simMobile.Description());
            Console.ReadKey();
        }
    }
}
