using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    class AppleFactory : TechFactory
    {
        public override SmartPhone CreateSmartPhone()
        {
            return new AppleSmartPhone();
        }

        public override SmartWatch CreateSmartWatch()
        {
            return new AppleSmartWatch();
        }

        public override Tablet CreateTablet()
        {
            return new AppleTablet();
        }
    }
}
