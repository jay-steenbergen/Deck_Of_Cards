using Microsoft.VisualStudio.TestTools.UnitTesting;
using Deck_Of_Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deck_Of_Cards.Tests
{
    [TestClass()]
    public class DeckTests
    {
        [TestMethod()]
        public void createDeckTest_Length_of_deck()
        {
            // arrange
            Deck deck = new Deck();
            // act
            var cardDeck = deck.createDeck();
            

            //assert
            Assert.IsTrue(cardDeck.Count == 52);
        }
 
        public void createDeckTest_Values_In_Deck()
        {
            // arrange
            Deck deck = new Deck();
            var actual = deck.createDeck();
            // act
            var expected = new List<KeyValuePair<string, string>>();
            expected.Add(new KeyValuePair<string, string>("Two", "Hearts" )) ;
            expected.Add(new KeyValuePair<string, string>("Three", "Hearts"));
            expected.Add(new KeyValuePair<string, string>("Four", "Hearts"));
            expected.Add(new KeyValuePair<string, string>("Five", "Hearts"));
            expected.Add(new KeyValuePair<string, string>("Six", "Hearts"));
            expected.Add(new KeyValuePair<string, string>("Seven", "Hearts"));
            expected.Add(new KeyValuePair<string, string>("Eight", "Hearts"));
            expected.Add(new KeyValuePair<string, string>("Nine", "Hearts"));
            expected.Add(new KeyValuePair<string, string>("Ten", "Hearts"));
            expected.Add(new KeyValuePair<string, string>("Jack", "Hearts"));
            expected.Add(new KeyValuePair<string, string>("Queen", "Hearts"));
            expected.Add(new KeyValuePair<string, string>("Key", "Hearts"));
            expected.Add(new KeyValuePair<string, string>("Ace", "Hearts"));

            expected.Add(new KeyValuePair<string, string>("Two", "Spades"));
            expected.Add(new KeyValuePair<string, string>("Three", "Spades"));
            expected.Add(new KeyValuePair<string, string>("Four", "Spades"));
            expected.Add(new KeyValuePair<string, string>("Five", "Spades"));
            expected.Add(new KeyValuePair<string, string>("Six", "Spades"));
            expected.Add(new KeyValuePair<string, string>("Seven", "Spades"));
            expected.Add(new KeyValuePair<string, string>("Eight", "Spades"));
            expected.Add(new KeyValuePair<string, string>("Nine", "Spades"));
            expected.Add(new KeyValuePair<string, string>("Ten", "Spades"));
            expected.Add(new KeyValuePair<string, string>("Jack", "Spades"));
            expected.Add(new KeyValuePair<string, string>("Queen", "Spades"));
            expected.Add(new KeyValuePair<string, string>("King", "Spades"));
            expected.Add(new KeyValuePair<string, string>("Ace", "Spades"));

            expected.Add(new KeyValuePair<string, string>("Two", "Clubs"));
            expected.Add(new KeyValuePair<string, string>("Three", "Clubs"));
            expected.Add(new KeyValuePair<string, string>("Four", "Clubs"));
            expected.Add(new KeyValuePair<string, string>("Five", "Clubs"));
            expected.Add(new KeyValuePair<string, string>("Six", "Clubs"));
            expected.Add(new KeyValuePair<string, string>("Seven", "Clubs"));
            expected.Add(new KeyValuePair<string, string>("Eight", "Clubs"));
            expected.Add(new KeyValuePair<string, string>("Nine", "Clubs"));
            expected.Add(new KeyValuePair<string, string>("Ten", "Clubs"));
            expected.Add(new KeyValuePair<string, string>("Jack", "Clubs"));
            expected.Add(new KeyValuePair<string, string>("Queen", "Clubs"));
            expected.Add(new KeyValuePair<string, string>("Key", "Clubs"));
            expected.Add(new KeyValuePair<string, string>("Ace", "Clubs"));

            expected.Add(new KeyValuePair<string, string>("Two", "Diamonds"));
            expected.Add(new KeyValuePair<string, string>("Three", "Diamonds"));
            expected.Add(new KeyValuePair<string, string>("Four", "Diamonds"));
            expected.Add(new KeyValuePair<string, string>("Five", "Diamonds"));
            expected.Add(new KeyValuePair<string, string>("Six", "Diamonds"));
            expected.Add(new KeyValuePair<string, string>("Seven", "Diamonds"));
            expected.Add(new KeyValuePair<string, string>("Eight", "Diamonds"));
            expected.Add(new KeyValuePair<string, string>("Nine", "Diamonds"));
            expected.Add(new KeyValuePair<string, string>("Ten", "Diamonds"));
            expected.Add(new KeyValuePair<string, string>("Jack", "Diamonds"));
            expected.Add(new KeyValuePair<string, string>("Queen", "Diamonds"));
            expected.Add(new KeyValuePair<string, string>("King", "Diamonds"));
            expected.Add(new KeyValuePair<string, string>("Ace", "Diamonds"));

            
            //assert
            Assert.AreEqual(expected, actual );
        }

    }
}