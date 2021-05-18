using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    class HuaweiFactory : TechFactory
    {
        public override SmartPhone CreateSmartPhone()
        {
            return new HuaweiSmartPhone();
        }

        public override SmartWatch CreateSmartWatch()
        {
            return new HuaweiSmartWatch();
        }

        public override Tablet CreateTablet()
        {
            return new HuaweiTablet();
        }
    }
}
