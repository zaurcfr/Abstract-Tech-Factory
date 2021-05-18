using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    class AppleSmartPhone : SmartPhone
    {
        public string Name { get; set; }
        public string OS { get; set; }
        public string Vendor { get; set; }
        public AppleSmartPhone()
        {
            Name = "Iphone 12 Pro Max";
            OS = "iOS";
            Vendor = "Apple";
        }
    }
}
