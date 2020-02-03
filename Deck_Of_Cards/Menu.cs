using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{
    class Menu
    {
        public void GameMenu(List<Player> listOfPlayers, List<KeyValuePair<string, string>> shuffledDeck)
        {
			while (true)
			{
				Deal deal = new Deal();
				PlayersHand playersHand = new PlayersHand();
				ShowPlayers showPlayers = new ShowPlayers();
				var writer = new ConsoleWriter();
				var dispatcher = new MessageDispatcher(writer);
				/////////////////////////////////////////////////////////////////////////////////
				Console.Clear();
				Console.ResetColor();
				Console.WriteLine("=============================================================");
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.Write("     Deck Of Cards   ");
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.Write("Players: ");
				Console.ForegroundColor = ConsoleColor.Cyan;
				var getPlayers = showPlayers.PrintPlayers(listOfPlayers); //// Display Player names on screen
				dispatcher.SendMessage(getPlayers);

				Console.ResetColor();
				Console.WriteLine("\n=============================================================");
				////////////////////////////////////////////////////////////////////////////////

				Console.WriteLine("Do you want to deal one card? Y/N");
				var input = Console.ReadLine().ToLower().Trim();

				if (input == "y")
				{
					var deltCard = deal.dealOneCard(shuffledDeck);

					playersHand.AddCardToHand(deltCard, listOfPlayers);

					Console.Write("\nDelt the ");
					Console.ForegroundColor = ConsoleColor.Magenta;
					Console.WriteLine(deltCard);
					Console.ResetColor();

					Console.WriteLine("\nYour hand:");
					Console.ForegroundColor = ConsoleColor.Cyan;

					showPlayers.PrintHand(listOfPlayers);
					Console.ResetColor();

					Console.WriteLine("\nPress enter....");

					Console.ReadLine();
				}

				else if (input == "n")
				{
					Console.WriteLine("You hand is: \n");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("Your final  \n\n");
					Console.ForegroundColor = ConsoleColor.Cyan;
					showPlayers.PrintHand(listOfPlayers);
					Console.ResetColor();
					break;
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("\nInvalid input \nPress enter....");
					Console.ResetColor();
					Console.ReadLine();
				}
			}
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"\n\n\n                   Thanks for playing!");
			Console.ResetColor();
			Console.ReadLine();
		}
    }
}
