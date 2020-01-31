using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{
    public class ShowPlayers
    {
        public void PrintPlayers(List<Player> listOfPlayers)
        {
            foreach (var player in listOfPlayers)
            {
                Console.Write($"{player.Name}  ");
            };           
        }
        public void PrintHand(List<Player> listOfPlayers)
        {
            foreach (var player in listOfPlayers)
            {
                Console.WriteLine(player.Name);
                Console.WriteLine("-----------");
                foreach (var card in player.Hand)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine("\n\n");
            };
        }
    }
}
