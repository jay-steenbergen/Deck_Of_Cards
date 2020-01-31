
using System;
using System.Collections.Generic;


namespace Deck_Of_Cards
{
    public class CreatePlayers 
    {
        public List<Player> listOfPlayers = new List<Player>();
        public List<Player> HowManyPlayers()
        {
            /// User enters in the Number of player 
            int input;
            while (true)
            {
                Console.Write("How many players: ");
                var amountOfPlayers = Console.ReadLine();
                bool parseSuccess = int.TryParse(amountOfPlayers, out input);
                if (parseSuccess)
                {
                    input = Convert.ToInt32(amountOfPlayers);
                    var listOfPlayers = EnterNameOfPlayers(input);
                    return listOfPlayers;
                }
                else
                    Console.WriteLine("Invalid entry. Try again....");
            }
        }

        public List<Player> EnterNameOfPlayers(int input)
            {
            /// User can now enter Names of players
            for (int i = 0; i < input;)
            {
                Console.Write("Enter name: ");
                string newPlayer = Convert.ToString(Console.ReadLine().Trim());
                if (newPlayer.Length <= 0)
                {
                    Console.WriteLine("Invalid Entry....");
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
