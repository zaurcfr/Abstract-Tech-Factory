using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    class SamsungTablet : Tablet
    {
        public string Name { get; set; }
        public string Vendor { get; set; }
        public SamsungTablet()
        {
            Name = "Samsung Tab";
            Vendor = "Samsung";
        }
    }
}
