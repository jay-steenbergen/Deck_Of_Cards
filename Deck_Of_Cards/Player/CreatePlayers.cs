
using System;
using System.Collections;
using System.Collections.Generic;
using static Deck_Of_Cards.WriteClass;

namespace Deck_Of_Cards
{
    public class CreatePlayers  
    {
        IWriteClass _writer;
        public CreatePlayers(IWriteClass writer)
        {
            _writer = writer;
        }
        public List<Player> listOfPlayers = new List<Player>();
        public List<Player> HowManyPlayers()
        {
            /// User enters in the Number of player 
            int input;
            while (true)
            {
                _writer.WriteLine(Colors.None, "How many players: ");
                var amountOfPlayers = Console.ReadLine();
                bool parseSuccess = int.TryParse(amountOfPlayers, out input);
                if (parseSuccess)
                {
                    input = Convert.ToInt32(amountOfPlayers);
                    var listOfPlayers = EnterNameOfPlayers(input);
                    return listOfPlayers;
                }
                else
                    _writer.WriteLine(Colors.Yellow, "Invalid entry. Try again....");
            }
        }

        public List<Player> EnterNameOfPlayers(int input)
        {
            /// User can now enter Names of players
            for (int i = 0; i < input;)
            {
                _writer.Write(Colors.None, "Enter name: ");
                string newPlayer = Convert.ToString(Console.ReadLine().Trim());
                if (newPlayer.Length <= 0)
                {
                    _writer.WriteLine(Colors.Red, "Invalid Entry....");
                }
                else
                {
                    listOfPlayers.Add(new Player(newPlayer, i));
                    i++;
                }
            }
            return listOfPlayers;
        }

    }   
}
