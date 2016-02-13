using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Autos;
using Decorator.Functions;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoList = new List<AutoBase>() {
                new AUDI(),
                new BMW(),
                new Tires(new AUDI()),
                new Insurance(new Tires(new Turbo(new AUDI()))),
                new Turbo(new Insurance(new BMW()))
            };

            foreach (var auto in autoList)
            {
                PrintAuto(auto);
            }

            Console.ReadKey();
        }

        public static void PrintAuto(AutoBase autoBase)
        {
            Console.WriteLine("**********************************\n");
            Console.WriteLine("Машина {0}\nПолная стоимость составляет {1}$\n", autoBase.GetDescription(), autoBase.GetCost());
            Console.WriteLine("**********************************\n");
        }
    }
}
