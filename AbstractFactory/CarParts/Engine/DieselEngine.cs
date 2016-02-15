using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarParts.Engine
{
    public class DieselEngine: IEngine
    {
        public DieselEngine()
        {
            Console.WriteLine("DIESEL ENGINE");
        }
    }
}
