using TwitterUCU;
using System;
namespace Library
{
    public class Twitter :  IMessageChannel
    {
        public static void Send(Message message)
        {
            var c = message.From.Search(message.To);
            foreach (Contact contacto in c)
            {
                Console.WriteLine(contacto.Name);
                var twitterDirectMessage = new TwitterMessage();
                Console.WriteLine(twitterDirectMessage.SendMessage(message.Text, contacto.Email));
            }
        }
    }
}