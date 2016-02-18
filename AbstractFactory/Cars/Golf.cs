using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory;

namespace AbstractFactory.Cars
{
    public class Golf: Car
    {
        public Golf(IBasicFactory factory)
        {
            CarName = "Golf";
            Factory = factory;
        }
    }
}
