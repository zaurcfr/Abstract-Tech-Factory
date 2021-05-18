using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    class HuaweiSmartWatch : SmartWatch
    {
        public string Name { get; set; }
        public int CaseSize { get; set; }
        public string Vendor { get; set; }
        public HuaweiSmartWatch()
        {
            Name = "Huawei Smart Watch";
            CaseSize = 40;
            Vendor = "Huawei";
        }
    }
}
