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
        public void WritTwoPropertiesList(List<string> listMessage)
        {
            foreach (var firstItem in listMessage)
            {
                Console.WriteLine(firstItem);
                Console.WriteLine("-----------");
                foreach (var secondItem in firstItem)
                {

                }
            }
        }
    }
}
