using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Devices
{
    public class AndroidDevice: IObserver
    {
        private string _name;
        private string _message;

        public AndroidDevice(string name)
        {
            _name = name;
        }

        public void Display()
        {
            Console.WriteLine("Device :: {0}, Message :: {1}", _name, _message);
        }

        public void Update(object sender, string message)
        {
            _message = message;
            Display();
        }
    }
}
