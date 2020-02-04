using System;
using System.Collections.Generic;
using static Deck_Of_Cards.WriteClass;

namespace Deck_Of_Cards
{
    class Menu 
    {
		IWriteClass _writer;
		IDeal _deal;
		IPlayersHand _playersHand;
		IShowPlayers _showPlayers;

		public Menu(IWriteClass writer, IDeal deal, IPlayersHand playersHand, IShowPlayers showPlayer)
		{
			_writer = writer;
			_deal = deal;
			_playersHand = playersHand;
			_showPlayers = showPlayer;

		}
        public void GameMenu(List<Player> listOfPlayers, List<KeyValuePair<string, string>> shuffledDeck)
        {
			while (true)
			{
				/////////////////////////////////////////////////////////////////////////////////
				_writer.Clear();
				_writer.Deceminter();
				_writer.Write(Colors.Blue, "     Deck Of Cards   ");
				_writer.Write(Colors.Blue, "Players: ");
				var getPlayerNames = _showPlayers.GetPlayerNames(listOfPlayers); //// Display Player names on screen
				_writer.WriteList(Colors.Cyan, getPlayerNames);
				Console.WriteLine();
				_writer.Deceminter();
				////////////////////////////////////////////////////////////////////////////////

				_writer.WriteLine(Colors.None, "Do you want to deal one card? Y/N");
				var input = Console.ReadLine().ToLower().Trim();

				if (input == "y")
				{
					var deltCard = _deal.dealOneCard(shuffledDeck);

					_playersHand.AddCardToHand(deltCard, listOfPlayers);

					_writer.Write(Colors.None, "\nDelt the ");
					_writer.WriteLine(Colors.Magenta, deltCard);
					_writer.WriteLine(Colors.None, "\nYour hand:");
					_showPlayers.PrintHand(listOfPlayers);
					_writer.WriteLine(Colors.None, "\nPress enter....");
					Console.ReadLine();
				}

				else if (input == "n")
				{
					_writer.WriteLine(Colors.None, "You hand is: \n");
					_writer.Write(Colors.Red, "Your final  \n\n");
					Console.ForegroundColor = ConsoleColor.Cyan;
					_showPlayers.PrintHand(listOfPlayers);
					Console.ResetColor();
					break;
				}
				else
				{
					_writer.WriteLine(Colors.Yellow, "\nInvalid input \nPress enter....");
					Console.ReadLine();
				}
			}
			_writer.WriteLine(Colors.Red, $"\n\n\n                   Thanks for playing!");
			Console.ReadLine();
		}
    }
}
