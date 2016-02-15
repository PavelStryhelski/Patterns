using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarParts.Wheels
{
    public class MediumWheels: IWheels
    {
        public MediumWheels()
        {
            Console.WriteLine("MEDIUM WHEELS");
        }
    }
}
