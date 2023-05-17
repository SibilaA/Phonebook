using TwitterUCU;
using System;
namespace Library
{
    public class TwitterMessages : Message
    {
        public TwitterMessages (Phonebook from, string[] to) : base (from, to)
        {
        }
    }
}