using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer.Subject
{
    public delegate void MessagesContentEventHandler(object sender, string message);

    public class Messages
    {
        public event MessagesContentEventHandler ContentChanged;

        private readonly Random _random;

        public Messages()
        {
            _random = new Random();
        }

        private string GetMessage()
        {
            var messages = new[] { "Сообщение первое", "Тестирование Push уведомлений", "Срочная новость", "Оповещение!!!" };

            return messages[_random.Next(messages.Count())];
        }

        public void MessagesAvailable()
        {
            if (ContentChanged != null)
            {
                ContentChanged(this, GetMessage());
            }
        }
    }
}
