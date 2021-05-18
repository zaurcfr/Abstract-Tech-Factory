﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    class HuaweiSmartPhone : SmartPhone
    {
        public string Name { get; set; }
        public string OS { get; set; }
        public string Vendor { get; set; }

        public HuaweiSmartPhone()
        {
            Name = "Huawei Smart Phone";
            OS = "Huawei OS";
            Vendor = "Huawei";
        }
    }
}
