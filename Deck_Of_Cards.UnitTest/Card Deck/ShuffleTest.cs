using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deck_Of_Cards.UnitTest
{
    [TestClass()]
    public class ShuffleTest
    {
        [TestMethod]
        public void ShuffleTest_CanShuffleDeck_DeckShouldBeShuffle()
        {
            //Arrange
            var shuffle = new Shuffle();
            //Act
            var actual = new List<KeyValuePair<string, string>>();
            actual.Add(new KeyValuePair<string, string>("Key1", "Value1"));
            actual.Add(new KeyValuePair<string, string>("Key2", "Value2"));
            actual.Add(new KeyValuePair<string, string>("Key3", "Value3"));

            var expected = new List<KeyValuePair<string, string>>();

            expected.Add(new KeyValuePair<string, string>("Key1", "Value1"));
            expected.Add(new KeyValuePair<string, string>("Key2", "Value2"));
            expected.Add(new KeyValuePair<string, string>("Key3", "Value3"));

            var shuffled = shuffle.shuffleDeck(actual);


            int j = 0;
            for (int i = 0; i <= 10; i++)
            {
                if(expected.TrueForAll(shuffled.Contains))
                {
                    j++;
                }
                shuffled = shuffle.shuffleDeck(shuffled);
            }
            //Assert
            Assert.IsFalse(j == 0);
        }

    }
}
