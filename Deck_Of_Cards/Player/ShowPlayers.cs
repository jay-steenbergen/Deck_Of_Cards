using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{
    public class ShowPlayers
    {
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
        public List<string> GetPlayerNames(List<Player> listOfPlayers)
        {
            var listOfNames = new List<string>();
            foreach (var player in listOfPlayers)
            {
                listOfNames.Add(player.Name);
            };
            return listOfNames;
        }
        static List<string> GetHand(List<Player> listOfPlayers, string playerName)
        {
            var listOfCards = new List<string>();
            foreach (var player in listOfPlayers)
            {
                if (player.Name.Contains(playerName))
                {
                    foreach (var card in player.Hand)
                    {
                        listOfCards.Add(card);
                    }
                }
            }
            return listOfCards;
        }
    }
}
