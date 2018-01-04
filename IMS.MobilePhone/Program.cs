using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.IMS.MobilePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            SimCorpMobile simMobile = new SimCorpMobile();
            Console.WriteLine(simMobile.Description());
            Console.ReadKey();
        }
    }
}
