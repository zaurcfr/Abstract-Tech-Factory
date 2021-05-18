using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    class HuaweiTablet : Tablet
    {
        public string Name { get; set; }
        public string Vendor { get; set; }
        public HuaweiTablet()
        {
            Name = "Huawei Tab";
            Vendor = "Huawei";
        }
    }
}
