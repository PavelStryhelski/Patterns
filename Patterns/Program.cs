using System;
using System.Collections.Generic;
using Patterns.Roles;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            users.Add(new Administrator());
            users.Add(new Editor());
            users.Add(new Guest());

            foreach (var user in users)
            {
                Console.WriteLine("************\n");
                user.WhoIs();
                user.Read();
                user.Add();
                user.Edit();
                user.Remove();
                Console.WriteLine("\n************\n\n");
            }

            Console.ReadKey();

        }
    }
}
