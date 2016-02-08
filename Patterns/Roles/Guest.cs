using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Actions.Adding;
using Patterns.Actions.Removing;

namespace Patterns.Roles
{
    public class Guest: User
    {
        public Guest()
        {
            Removing = new HalfRemoving();
        }

        public override void WhoIs()
        {
            Console.WriteLine("I`m a guest");
        }
    }
}
