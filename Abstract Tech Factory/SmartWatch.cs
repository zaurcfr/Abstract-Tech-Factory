using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    interface SmartWatch
    {
        string Name { get; set; }
        int CaseSize { get; set; }
        string Vendor { get; set; }
    }
}
