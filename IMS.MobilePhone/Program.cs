using System;

namespace Simcorp.IMS.MobilePhone {
    class Program {
        static void Main(string[] args) {
            SimCorpMobile simMobile = new SimCorpMobile();
            Console.WriteLine(simMobile.Description());
            Console.ReadKey();
        }
    }
}
