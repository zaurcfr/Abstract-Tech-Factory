using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Tech_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Tech Factory, 'A' for Apple,'S' for Samsung,'H' for Huawei");
            string choice = Console.ReadLine();

            TechFactory techFactory = null;

            if (choice == "A") techFactory = new AppleFactory();
            else if (choice == "S") techFactory = new SamsungFactory();
            else if (choice == "H") techFactory = new HuaweiFactory();

            Console.WriteLine(techFactory.CreateSmartPhone().Name);
            Console.WriteLine(techFactory.CreateSmartWatch().Name);
            Console.WriteLine(techFactory.CreateTablet().Name);
        }
    }
}
