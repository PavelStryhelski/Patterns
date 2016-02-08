using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Editing
{
    public class AllEditing : IEditing
    {
        public void Editing()
        {
            Console.WriteLine("I can edit everything I Want");
        }
    }
}
