using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.IMS.MobilePhone {
    public interface IBattery {
        int Charge { get; set; }
        int Volume { get; set; }
        void GetStatus(IBattery battery, int volume, int charge);
    }
}
