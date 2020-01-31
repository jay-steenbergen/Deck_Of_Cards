﻿using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{
    public class PlayersHand
    {              
        public void AddCardToHand(string deltCard, List<Player> listOfPlayers)
        {
            var flag = true;
            while (flag)
            {               
                Console.WriteLine("What player do you want to deal: ");
                string playerName = Convert.ToString(Console.ReadLine());
                int count = 0;
                foreach (var player in listOfPlayers)
                {
                    if(playerName.Length <= 0)
                    {
                        Console.WriteLine("No player found...\n");
                        break;
                    }
                    else if (player.Name.Contains(playerName, StringComparison.CurrentCultureIgnoreCase))
                    {
                        player.Hand.Add(deltCard);

                        flag = false;
                        break;
                    }
                    else if(count == listOfPlayers.Count - 1)
                    {
                        Console.WriteLine("No player found...\n");
                    }
                    count++;
                }              
            }
        }
    }
}
