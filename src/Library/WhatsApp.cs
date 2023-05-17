using System;
using WhatsAppApiUCU;
namespace Library
{
    public class WhatsApp : IMessageChannel
    {
        public static void Send(Message message)
        {
            var c = message.From.Search(message.To);
            foreach (Contact contacto in c)
            {
                Console.WriteLine(contacto.Name);
                var whatsApp = new WhatsAppApi();
                string sid = whatsApp.Send(contacto.Phone, message.Text);
                Console.WriteLine(sid);
            }
        }
    }
}