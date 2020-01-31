using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deck_Of_Cards.UnitTest
{
    [TestClass]
    class PlayersHandTest
    {
        [TestMethod]
        public void AddCardToHand_AddsCardToPlayer()
        {
            // Arrange
            PlayersHand playersHand = new PlayersHand();
            var testList = new List<Player>();
            testList.Add(new Player("Jay", 0));
            testList.Add(new Player("Debra", 1));
            testList.Add(new Player("Hershey", 2));
            string deltCard = "test";
            // Act
            playersHand.AddCardToHand(deltCard, testList);

            // Assert

        }
    }
}
