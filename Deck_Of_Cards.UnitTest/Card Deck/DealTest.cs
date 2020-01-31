using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Deck_Of_Cards.UnitTest
{
    [TestClass()]
    public class DealTest
    {
        [TestMethod]
        //Arrange
        public void DealOneCardTest_DeckCountGreaterThanZero_ReturnFirstElement()
        {
            //Arrange
            var deal = new Deal();
            var actual = new List<KeyValuePair<string, string>>();
            actual.Add(new KeyValuePair<string, string>("Key1", "Value1"));
            actual.Add(new KeyValuePair<string, string>("Key2", "Value2"));
            actual.Add(new KeyValuePair<string, string>("Key3", "Value3"));
            //Act
            var expected = deal.dealOneCard(actual);
            //Assert
            Assert.AreEqual(expected, "Key1 Value1");

        }
        [TestMethod]
        public void DealOneCard_DeckCountZero_ReturnError()
        {
            //Arrange
            var deal = new Deal();
            var actual = new List<KeyValuePair<string, string>>();
            actual.Add(new KeyValuePair<string, string>("Key1", "Value1"));
            
            //Act
            var expected = deal.dealOneCard(actual);
            expected = deal.dealOneCard(actual);

            //Assert
            Assert.AreEqual(expected, "There are no more cards in the deck\n");

        }
    }
}
