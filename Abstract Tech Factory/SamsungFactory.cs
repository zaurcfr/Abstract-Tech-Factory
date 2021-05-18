using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    class SamsungFactory : TechFactory
    {
        public override SmartPhone CreateSmartPhone()
        {
            return new SamsungSmartPhone();
        }

        public override SmartWatch CreateSmartWatch()
        {
            return new SamsungSmartWatch();
        }

        public override Tablet CreateTablet()
        {
            return new SamsungTablet();
        }
    }
}
