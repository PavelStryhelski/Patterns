using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Devices
{
    public interface IObserver
    {
        void Display();

        void Update(object sender, string message);
    }
}
