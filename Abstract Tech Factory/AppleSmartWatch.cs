using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    class AppleSmartWatch : SmartWatch
    {
        public string Name { get; set; }
        public int CaseSize { get; set; }
        public string Vendor { get; set; }
        public AppleSmartWatch()
        {
            Name = "Apple Watch Series 6";
            CaseSize = 44;
            Vendor = "Apple";
        }
    }
}
