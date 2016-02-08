using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Actions.Adding;
using Patterns.Actions.Removing;
using Patterns.Editing;

namespace Patterns.Roles
{
    public class Editor: User
    {
        public Editor()
        {
            Editing = new AllEditing();
            Removing = new HalfRemoving();
            Adding = new HalfAdding();
        }

        public override void WhoIs()
        {
            Console.WriteLine("I am an Editor!");
        }
    }
}
