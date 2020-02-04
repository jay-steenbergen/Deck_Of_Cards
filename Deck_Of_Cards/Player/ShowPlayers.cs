using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{
    public class ShowPlayers : WriteClass
    {
        public void PrintHand(List<Player> listOfPlayers)
        {
            foreach (var player in listOfPlayers)
            {
                Console.WriteLine(player.Name);
                WriteLine(Colors.Cyan, "-----------");
                foreach (var card in player.Hand)
                {
                    WriteLine(Colors.Cyan, card);
                }       
            };
        }
        public List<string> GetPlayerNames(List<Player> listOfPlayers)
        {
            var listOfNames = new List<string>();
            foreach (var player in listOfPlayers)
            {
                listOfNames.Add(player.Name);
            };
            return listOfNames;
        }
    }
}
