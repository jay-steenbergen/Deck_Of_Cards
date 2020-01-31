using System;
using System.Collections.Generic;
using System.Text;

namespace Deck_Of_Cards
{
	public class Shuffle : Deck
	{
		//Put shuffle cards into a shuffle deck list and deletes cards from Cards list.
		public List<KeyValuePair<string, string>> shuffleDeck(List<KeyValuePair<string, string>> cards)
		{
			Random random = new Random();
			
			var shuffleDeck = new List<KeyValuePair<string, string>>();
			
			while (cards.Count > 0)
			{
				var randomIndex = random.Next(0, cards.Count);
				shuffleDeck.Add(cards[randomIndex]);
				cards.Remove(cards[randomIndex]);
			}
			return shuffleDeck;
		}
	}
}
