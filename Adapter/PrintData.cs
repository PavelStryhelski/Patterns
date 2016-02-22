using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Adapters;

namespace Adapter
{
    public static class PrintData
    {
        public static void PrintUserInfo(IAdapter adapter)
        {
            Console.WriteLine("Имя:\t\t\t {0}", adapter.Name);
            Console.WriteLine("Возраст:\t\t {0}", adapter.Age);
            Console.WriteLine("Количество друзей:\t {0}", adapter.NumberOfFriends);
            Console.WriteLine("------- -------- ------- -------");
        }
    }
}
