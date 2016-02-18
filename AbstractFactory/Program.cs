using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Cars;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IBasicFactory euFactory = new EUFactory();
            IBasicFactory rusFactory = new RusFactory();

            Car polo = new Polo(euFactory);
            Car golf = new Golf(rusFactory);

            polo.Configure();

            Console.WriteLine("----------------------");

            golf.Configure();

            Console.ReadKey();
        }
    }
}
