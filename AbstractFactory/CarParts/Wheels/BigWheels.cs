using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarParts.Wheels
{
    public class BigWheels: IWheels
    {
        public BigWheels()
        {
            Console.WriteLine("BIG WHEELS");
        }
    }
}
