using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{
    public class Program
    {
        

        static void Main(string[] args)
        {			
			Deck deck = new Deck();
			Shuffle shuffle = new Shuffle();
			CreatePlayers createPlayers = new CreatePlayers();
			Menu menu = new Menu();
			List<KeyValuePair<string, string>> cards = deck.createDeck();
			List<KeyValuePair<string, string>> shuffledDeck = shuffle.shuffleDeck(cards);

			var listOfPlayers = createPlayers.HowManyPlayers();
			menu.GameMenu(listOfPlayers, shuffledDeck);
		}
    }
}
