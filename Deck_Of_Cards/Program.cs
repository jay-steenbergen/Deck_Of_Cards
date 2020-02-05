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
			WriteClass writer = new WriteClass();
			Deal deal = new Deal();
			PlayersHand playersHand = new PlayersHand(writer);
			ShowPlayers showPlayers = new ShowPlayers(writer);
			UserInput userInput = new UserInput(writer);
			CreatePlayers createPlayers = new CreatePlayers(writer, userInput);
			Menu menu = new Menu(writer, deal, playersHand, showPlayers);
			List<KeyValuePair<string, string>> cards = deck.createDeck();
			List<KeyValuePair<string, string>> shuffledDeck = shuffle.shuffleDeck(cards);

			var numberOfPlayers = createPlayers.HowManyPlayers();
			var listOfPlayers = createPlayers.EnterNameOfPlayers(numberOfPlayers);
			menu.GameMenu(listOfPlayers, shuffledDeck);
		}
    }
}
