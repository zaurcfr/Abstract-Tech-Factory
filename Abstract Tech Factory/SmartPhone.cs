using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    interface SmartPhone
    {
        string Name { get; set; }
        string OS { get; set; }
        string Vendor { get; set; }
    }
}
