using System;
using System.Collections.Generic;
using static Deck_Of_Cards.WriteClass;

namespace Deck_Of_Cards
{
	public class Menu : IMenu
	{
		IWriteClass _writer;
		IMenuWriter _menuWriter;
		IUserInput _userInput;
		public Menu(IWriteClass writer, IMenuWriter menuWriter, IUserInput userInput)
		{
			_writer = writer;
			_menuWriter = menuWriter;
			_userInput = userInput;
		}
		public void GameMenu(List<Player> listOfPlayers, List<KeyValuePair<string, string>> shuffledDeck)
		{
			while (true)
			{
				_menuWriter.WriteBanner(listOfPlayers);
				var input = _userInput.MenuAnswer();
				if (input == "y")
				{
					_menuWriter.WriteYes(listOfPlayers, shuffledDeck);
				}

				else if (input == "n")
				{
					_menuWriter.WriteNo(listOfPlayers);
					break;
				}
				else
				{
					_menuWriter.WriteDefualt();
				}
			}
			_writer.WriteLine(Colors.Red, "Thanks for playing!");
			_writer.ReadLine();
		}
	}
}
