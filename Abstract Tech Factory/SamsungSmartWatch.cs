using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    class SamsungSmartWatch : SmartWatch
    {
        public string Name { get; set; }
        public int CaseSize { get; set; }
        public string Vendor { get; set; }
        public SamsungSmartWatch()
        {
            Name = "Samsung Gear S3";
            CaseSize = 42;
            Vendor = "Samsung";
        }
    }
}
