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
			UserInput userInput = new UserInput(writer);
			Deal deal = new Deal();
			PlayersHand playersHand = new PlayersHand(writer, userInput);
			ShowPlayers showPlayers = new ShowPlayers(writer);
			CreatePlayers createPlayers = new CreatePlayers(writer, userInput);
			Menu menu = new Menu(writer, deal, playersHand, showPlayers, userInput);
			List<KeyValuePair<string, string>> cards = deck.createDeck();
			List<KeyValuePair<string, string>> shuffledDeck = shuffle.shuffleDeck(cards);

			var numberOfPlayers = createPlayers.HowManyPlayers();
			var listOfPlayers = createPlayers.EnterNameOfPlayers(numberOfPlayers);
			menu.GameMenu(listOfPlayers, shuffledDeck);
		}
    }
}
