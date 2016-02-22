using System;
using Adapter.Adapters;
using Adapter.Sites;

namespace Adapter
{
    class Programm
    {
        public static void Main(string[] args)
        {
            IAdapter vkAdapter = new VkAdapter(new Vk("Вася пупкин", 20, 25));
            IAdapter facebookAdapter = new FacebookAdapter(new Facebook("Joseph", 150, 18));
            IAdapter odnoklassnikiAdapter = new OdnoklassnikiAdapter(new Odnoklassniki("Зинаида Ивановна", 2, 66));

            PrintData.PrintUserInfo(vkAdapter);
            PrintData.PrintUserInfo(facebookAdapter);
            PrintData.PrintUserInfo(odnoklassnikiAdapter);

            Console.ReadKey();
        }
    }
}
