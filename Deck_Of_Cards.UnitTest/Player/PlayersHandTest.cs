using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deck_Of_Cards.UnitTest
{

    [TestClass]
    public class PlayersHandTest
    {
        [TestMethod]
        public void AddCardToHand_AddsCardToPlayer()
        {
            // Arrange
            WriteClass write = new WriteClass();
            FakePostiveUserInput input = new FakePostiveUserInput();
            PlayersHand playersHand = new PlayersHand(write, input);

            var expectedtList = new List<Player>();
            expectedtList.Add(new Player("Test", 0));
            expectedtList.Add(new Player("Test2", 1));
            expectedtList.Add(new Player("Test3", 2));

            // Act
            var expected = input.GetStringInput();
            string deltCard = "testCard";
            playersHand.AddCardToHand(deltCard, expectedtList);

            // Assert
            foreach (var player in expectedtList)
                if(player.Name == expected)
                    Assert.IsTrue(player.Hand.Contains(deltCard));
        }
        [TestMethod]
        public void AddCardToHand_OtherPlayersDidNotAddCard()
        {
            // Arrange
            WriteClass write = new WriteClass();
            FakePostiveUserInput input = new FakePostiveUserInput();
            PlayersHand playersHand = new PlayersHand(write, input);

            var expectedtList = new List<Player>();
            expectedtList.Add(new Player("Test", 0));
            expectedtList.Add(new Player("Test2", 1));
            expectedtList.Add(new Player("Test3", 2));

            // Act
            var expected = input.GetStringInput();
            string deltCard = "testCard";
            playersHand.AddCardToHand(deltCard, expectedtList);

            // Assert
            foreach (var player in expectedtList)
                if (player.Name != expected)
                    Assert.IsFalse(player.Hand.Contains(deltCard));
        }

    }
}
