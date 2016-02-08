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
    public class Administrator: User
    {
        public Administrator()
        {
            Adding = new AllAdding();
            Editing = new AllEditing();
            Removing = new AllRemove();
        }

        public override void WhoIs()
        {
            Console.WriteLine("I am an administrator!");
        }
    }
}
