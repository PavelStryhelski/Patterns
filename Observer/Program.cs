using System;
using Observer.Devices;
using Observer.Subject;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var wp1 = new WinphoneDevice("Lumia 620");
            var wp2 = new WinphoneDevice("Lumia 1020");
            var wp3 = new WinphoneDevice("Lumia 930");

            var android1 = new AndroidDevice("Nexus 4");
            var android2 = new AndroidDevice("Nexus 5");
            var android3 = new AndroidDevice("Galaxy 3");

            var iphone1 = new IPhoneDevice("Iphone 4");
            var iphone2 = new IPhoneDevice("Iphone 5");
            var iphone3 = new IPhoneDevice("Iphone 6");

            var subject = new Messages();

            subject.ContentChanged += wp1.Update;
            subject.ContentChanged += wp2.Update;
            subject.ContentChanged += wp3.Update;

            subject.ContentChanged += android1.Update;
            subject.ContentChanged += android2.Update;
            subject.ContentChanged += android3.Update;

            subject.ContentChanged += iphone1.Update;
            subject.ContentChanged += iphone2.Update;
            subject.ContentChanged += iphone3.Update;

            //Первое PUSH уведомление
            subject.MessagesAvailable();


            Console.WriteLine("\n---Удаляем некоторые девайсы из рассылки---\n");
            //Удаляем из рассылки девайсы
            subject.ContentChanged -= wp1.Update;
            subject.ContentChanged -= android1.Update;
            subject.ContentChanged -= iphone2.Update;

            Console.WriteLine("\n---Были удалены некоторые девайсы из рассылки---\n");

            //Второе PUSH уведомление
            subject.MessagesAvailable();
            Console.WriteLine("\n---Третья рассылка---");
            //Третья рассылка
            subject.MessagesAvailable();

            Console.ReadKey();
        }
    }
}
