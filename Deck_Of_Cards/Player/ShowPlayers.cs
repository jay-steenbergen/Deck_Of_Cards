using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{
    public class ShowPlayers
    {
        public string PrintPlayers(List<Player> listOfPlayers)
        {
            int i = 0;
            while(i < listOfPlayers.Count)
            {
                    foreach (var player in listOfPlayers)
                    {
                        return player.Name;
                    };
            }
            return "No Players";

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
       
            };
            return "No Players";
        }
        public void TestIEnumerable()
        {

        }
    }
}
