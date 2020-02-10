using System;
using System.Collections.Generic;
using System.Text;
using static Deck_Of_Cards.WriteClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deck_Of_Cards.UnitTest
{
	public class FakeWriterClass : IWriteClass
	{

		public void Clear()
		{
			Console.Clear();
		}
		public void ReadLine()
		{
			Console.ReadLine();
		}
		public string Input()
		{
			return Console.ReadLine();
		}
		public void BlankLine()
		{
			Console.WriteLine();
		}
		public void Deliminter()
		{
			WriteLine(Colors.None, "============================================================= ");
		}
		public void Write(Colors color, string body)
		{
			Console.ResetColor();
			this.ApplyColor(color);
			Console.Write(body);
		}

		public void WriteLine(Colors color, string body)
		{
			Console.ResetColor();
			this.ApplyColor(color);
			Console.WriteLine(body);
		}
		public void WriteList(Colors color, List<string> list)
		{
			Console.ResetColor();
			this.ApplyColor(color);
			foreach (var item in list)
			{
				Console.Write(item + " ");
			}
		}
		private void ApplyColor(Colors color)
		{
			switch (color)
			{
				case Colors.Blue:
					{
						Console.ForegroundColor = ConsoleColor.Blue;
						break;
					}
				case Colors.Red:
					{
						Console.ForegroundColor = ConsoleColor.Red;
						break;
					}
				case Colors.Yellow:
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						break;
					}
				case Colors.Cyan:
					{
						Console.ForegroundColor = ConsoleColor.Cyan;
						break;
					}
				case Colors.Magenta:
					{
						Console.ForegroundColor = ConsoleColor.Magenta;
						break;
					}
				default:
					{
						Console.ForegroundColor = ConsoleColor.White;
						break;
					}

			}
		}
	}


    [TestClass]
    class MenuTest
    {
		[TestMethod]
		public void MenuTest_ReturnValue()
		{

			FakeWriterClass writer = new FakeWriterClass();
			FakeUserInput userInput = new FakeUserInput(writer);
			PlayersHand playersHand = new PlayersHand(writer, userInput);
			ShowPlayers showPlayers = new ShowPlayers(writer);
			Deal deal = new Deal();
			Menu menu = new Menu(writer, deal, playersHand, showPlayers, userInput);


			var mockList = new List < Player >();
			mockList.Add(new Player("Test", 0));
			mockList.Add(new Player("Test1", 1));
			mockList.Add(new Player("Test2", 2));
			var mockDeck = new List<KeyValuePair<string, string>>();
			mockDeck.Add(new KeyValuePair<string, string>("Key1", "Value1"));
			mockDeck.Add(new KeyValuePair<string, string>("Key2", "Value2"));
			mockDeck.Add(new KeyValuePair<string, string>("Key3", "Value3"));
			menu.GameMenu(mockList, mockDeck);



		}
	}
}
