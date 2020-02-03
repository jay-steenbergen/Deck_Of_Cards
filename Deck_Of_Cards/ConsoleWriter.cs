using System;
using System.Collections.Generic;
using System.Text;

namespace Deck_Of_Cards
{
    class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.WriteLine($"{message}");
        }
        public void WriteList(List<string> listMessage)
        {
            foreach (var item in listMessage)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
