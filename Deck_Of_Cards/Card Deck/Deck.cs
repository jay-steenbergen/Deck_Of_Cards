using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deck_Of_Cards
{
    public class Deck
    {
		private enum Suits
		{
			Hearts, 
			Spades,
			Clubs, 
			Diamonds,			
		}
		private enum Values
		{
			Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13, Ace = 14
		}
		public List<KeyValuePair<string, string>> createDeck()
		{
			//Converted Enums to list so I could combine them into 1 list for a full deck of cards.

			List<Suits> suits = Enum.GetValues(typeof(Suits)).Cast<Suits>().ToList();
			List<Values> values = Enum.GetValues(typeof(Values)).OfType<Values>().ToList();

			var cards = new List<KeyValuePair<string, string>>();


			for (int suitIndex = 0; suitIndex < suits.Count; suitIndex++)
			{
				
				for (int valIndex = 0; valIndex < values.Count; valIndex++)
				{
					cards.Add(new KeyValuePair<string, string>(values[valIndex].ToString(), suits[suitIndex].ToString()));
				}
			}

			return cards;
		}
	}
}


