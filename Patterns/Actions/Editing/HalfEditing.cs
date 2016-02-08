using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Editing
{
    public class HalfEditing: IEditing
    {
        public void Editing()
        {
            Console.WriteLine("I can edit only some materials");
        }
    }
}
