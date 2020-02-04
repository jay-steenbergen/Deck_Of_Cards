using System;
using System.Collections.Generic;
using System.Linq;

namespace Deck_Of_Cards
{
	public class Deal : IDeal
	{
		public string dealOneCard(List<KeyValuePair<string, string>> shuffledDeck)
		{
			//Returns the Value and Suit from the Key Value Pair as a string to display 
			//to the user. 

			string deltCardValue = "";
			string deltCardSuit = "";
			if (shuffledDeck.Count > 0)
			{
				deltCardValue = (from card in shuffledDeck
								 select card.Key)
								  .FirstOrDefault();

				deltCardSuit = (from card in shuffledDeck
								select card.Value)
								.FirstOrDefault();

				shuffledDeck.RemoveAt(0);

				string dealtCard = deltCardValue + " " + deltCardSuit;

				return dealtCard;
			}
			else
			{
				return "There are no more cards in the deck\n";
			}
		}
	}
}
