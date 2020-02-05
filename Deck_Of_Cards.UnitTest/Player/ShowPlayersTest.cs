using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deck_Of_Cards.UnitTest
{
    [TestClass]
    public class ShowPlayersTest
    {
        [TestMethod]
        public void PrintPlayers_IterateThoughtList()
        {
            // Arrange
            WriteClass writer = new WriteClass();
            ShowPlayers show = new ShowPlayers(writer);
            var expectedList = new List<Player>();
            expectedList.Add(new Player("Jay", 0));
            expectedList.Add(new Player("Debra", 1));
            expectedList.Add(new Player("Hershey", 2));

            // Act
            var actual = show.GetPlayerNames(expectedList);

            // Assert
            Assert.AreEqual(actual.Count, expectedList.Count);

        }
    }
}
