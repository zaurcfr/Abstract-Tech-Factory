﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    class AppleTablet : Tablet
    {
        public string Name { get; set; }
        public string Vendor { get; set; }
        public AppleTablet()
        {
            Name = "Ipad";
            Vendor = "Apple";
        }
    }
}
