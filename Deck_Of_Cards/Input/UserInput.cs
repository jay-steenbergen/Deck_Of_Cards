using System;
using System.Collections.Generic;
using System.Text;
using static Deck_Of_Cards.WriteClass;

namespace Deck_Of_Cards
{
    public class UserInput : IUserInput
    {
        IWriteClass _writer;
        public UserInput(IWriteClass writer)
        {
            _writer = writer;

        }
        public int GetIntInput()
        {
            int input;
            var amountOfPlayers = _writer.Input();
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
        public string MenuAnswer()
        {
            _writer.WriteLine(Colors.None, "Do you want to deal one card? Y/N");
            var input = Convert.ToString(Console.ReadLine().Trim());
            return input;
        }
    }
}
