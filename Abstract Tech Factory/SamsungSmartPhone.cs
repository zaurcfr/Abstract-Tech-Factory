using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    class SamsungSmartPhone : SmartPhone
    {
        public string Name { get; set; }
        public string OS { get; set; }
        public string Vendor { get; set; }
        public SamsungSmartPhone()
        {
            Name = "Samsung Galaxy S21 Ultra";
            OS = "Android";
            Vendor = "Samsung";
        }
    }
}
