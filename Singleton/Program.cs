using System;

namespace Singleton
{
    class Program
    {
        private static void Main(string[] args)
        {
            MySession.Instance["user"] = "Bob Scratcher";
            MySession.Instance["role"] = "Admin";

            Console.WriteLine(MySession.Instance.GetTime());
            Console.WriteLine(MySession.Instance["user"]);
            Console.WriteLine(MySession.Instance["role"]);
            Console.WriteLine(MySession.Instance.GetTime());
            Console.WriteLine(MySession.Instance.GetTime());

            Console.ReadKey();
        }

    }
}
