using System;
using System.Collections.Generic;
using System.Text;
using static Deck_Of_Cards.WriteClass;

namespace Deck_Of_Cards
{
    class UserInput : IUserInput
    {
        IWriteClass _writer;
        public UserInput(IWriteClass writer)
        {
            _writer = writer;
        }
        public int GetIntInput()
        {
            int input;
            var amountOfPlayers = Console.ReadLine().Trim();
            bool parseSuccess = int.TryParse(amountOfPlayers, out input);
            if (parseSuccess)
            {
                input = Convert.ToInt32(amountOfPlayers);
                return input;
            }
            else
                 return 0;
        }
        public string GetStringInput()
        {

            var stringInput = Convert.ToString(Console.ReadLine().Trim());
            return stringInput;
        }
    }
}
