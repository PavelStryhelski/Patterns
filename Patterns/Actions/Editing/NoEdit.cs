using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Editing
{
    public class NoEdit: IEditing
    {
        public void Editing()
        {
            Console.WriteLine("I cannot edit anything");
        }
    }
}
