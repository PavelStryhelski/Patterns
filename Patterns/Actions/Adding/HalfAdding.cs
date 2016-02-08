using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Actions.Adding
{
    public class HalfAdding: IAdding
    {
        public void Adding()
        {
            Console.WriteLine("I can add only some thing....");
        }
    }
}
