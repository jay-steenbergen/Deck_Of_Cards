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
        public void HowManyPlayers_PostiveNumber_CreatPlayers()
        {
            // Arrange
            CreatePlayers createPlayer = new CreatePlayers();

            // Act
            createPlayer.HowManyPlayers();
            int input = 3;
            createPlayer.EnterNameOfPlayers(input);

            // Assert

        }
    }
}
