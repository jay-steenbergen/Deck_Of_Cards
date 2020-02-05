using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deck_Of_Cards.UnitTest
{
    [TestClass]
    class CreatePlayerTest
    {
        [TestMethod]
        public void HowManyPlayers_PostiveNumber()
        {
            // Arrange
            WriteClass writer = new WriteClass();
            CreatePlayers createPlayer = new CreatePlayers(writer);
            int expected = 3;

            // Act
            var actual = createPlayer.HowManyPlayers();
          

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
