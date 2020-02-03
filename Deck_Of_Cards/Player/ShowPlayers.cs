using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{
    public class ShowPlayers
    {
        public string PrintPlayers(List<Player> listOfPlayers)
        {
            foreach (var player in listOfPlayers)
            {
                return player.Name;
            };
            return "I do not know what to put here";
        }
        public string PrintHand(List<Player> listOfPlayers)
        {
            foreach (var player in listOfPlayers)
            {
                Console.WriteLine(player.Name);
                Console.WriteLine("-----------");
                foreach (var card in player.Hand)
                {
                    return card;
                }
                return "I do not what to put here";
            };
            return "I do not what to put here";
        }
    }
}
