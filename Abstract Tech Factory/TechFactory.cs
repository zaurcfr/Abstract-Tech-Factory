using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    abstract class TechFactory
    {
        public abstract SmartPhone CreateSmartPhone();
        public abstract SmartWatch CreateSmartWatch();
        public abstract Tablet CreateTablet();
    }
}
