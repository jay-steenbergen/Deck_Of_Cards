using System;
using System.Collections.Generic;
using System.Text;

namespace Deck_Of_Cards
{
    class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.Write($"{message}");
        }

    }
}
