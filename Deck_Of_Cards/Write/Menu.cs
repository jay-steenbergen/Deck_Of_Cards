using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{
    class Menu : WriteClass
    {
		
        public void GameMenu(List<Player> listOfPlayers, List<KeyValuePair<string, string>> shuffledDeck)
        {
			while (true)
			{
				Deal deal = new Deal();
				PlayersHand playersHand = new PlayersHand();
				ShowPlayers showPlayers = new ShowPlayers();

				/////////////////////////////////////////////////////////////////////////////////
				Console.Clear();
				Deceminter();
				Write(Colors.Blue, "     Deck Of Cards   ");
				Write(Colors.Blue, "Players: ");
				var getPlayerNames = showPlayers.GetPlayerNames(listOfPlayers); //// Display Player names on screen
				WriteList(Colors.Cyan, getPlayerNames);
				Console.WriteLine();
				Deceminter();
				////////////////////////////////////////////////////////////////////////////////

				WriteLine(Colors.None, "Do you want to deal one card? Y/N");
				var input = Console.ReadLine().ToLower().Trim();

				if (input == "y")
				{
					var deltCard = deal.dealOneCard(shuffledDeck);

					playersHand.AddCardToHand(deltCard, listOfPlayers);

					Write(Colors.None, "\nDelt the ");
					WriteLine(Colors.Magenta, deltCard);
					WriteLine(Colors.None, "\nYour hand:");
					showPlayers.PrintHand(listOfPlayers);
					WriteLine(Colors.None, "\nPress enter....");
					Console.ReadLine();
				}

				else if (input == "n")
				{
					WriteLine(Colors.None, "You hand is: \n");
					Write(Colors.Red, "Your final  \n\n");
					Console.ForegroundColor = ConsoleColor.Cyan;
					showPlayers.PrintHand(listOfPlayers);
					Console.ResetColor();
					break;
				}
				else
				{
					WriteLine(Colors.Yellow, "\nInvalid input \nPress enter....");
					Console.ReadLine();
				}
			}
			WriteLine(Colors.Red, $"\n\n\n                   Thanks for playing!");
			Console.ReadLine();
		}
    }
}
