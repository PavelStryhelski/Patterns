using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory;

namespace AbstractFactory.Cars
{
    public class Polo: Car
    {
        public Polo(IBasicFactory factory)
        {
            CarName = "Polo";
            Factory = factory;
        }
    }
}
