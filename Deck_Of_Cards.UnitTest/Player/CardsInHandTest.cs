//using Deck_Of_Cards.Player;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Collections.Generic;


//namespace Deck_Of_Cards.UnitTest.Player
//{
//    [TestClass]
//    public class CardsInHandTest
//    {
//        [TestMethod]
//        public void AddCardToHand_AddCard_AddedCardToPlayer()
//        {
//            //Arrange
//            var expected = new List<string>() { "Test1", "Test2" };
//            var hand = new CardInHand();
//            var actual = hand.playersHand;

//            //Act
//            hand.AddCardToHand("Test1");
//            hand.AddCardToHand("Test2");

//            //Assert
//            CollectionAssert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void AddCardToHand_AddOver52_ReturnHandWith52()
//        {
//            //Arrange
//            var hand = new CardInHand();
//            var actual = hand.playersHand;
//            //Act
//            for (int i = 1; i <= 52; i++)
//            {
//                hand.AddCardToHand("Test1");
//            }
//            //Assert
//            Assert.IsTrue(actual.Count == 52);
//        }
//        [TestMethod]
//        public void AddCardToHand_ZeroCardsAdded_CardAdded()
//        {
//            //Arrange
//            var expected = new List<string>() { };
//            var hand = new ardInHand();
//            var actual = hand.playersHand;

//            //Act

//            //Assert
//            CollectionAssert.AreEqual(expected, actual);
//        }
//        //[TestMethod]
//        //public void AddCardToHand_ShowHand_DisplayCards()
//        //{
//        //    //Arrange
//        //    var expected = new List<string>() { "Test1", "Test2" };
//        //    var hand = new CardInHand();
//        //    var actual = hand.playersHand;

//        //    //Act
//        //    hand.AddCardToHand("Test1");
//        //    hand.AddCardToHand("Test2");

//        //    hand.ShowHand(hand.expected);
//        //}
//    }
//}
