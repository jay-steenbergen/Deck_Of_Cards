using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deck_Of_Cards.UnitTest
{
    public class FakeUserInput : IUserInput
    {
        public int GetIntInput()
        {
            return 3;
        }
        public string GetStringInput()
        {
            return "Test";
        }
    }
    [TestClass]
    public class CreatePlayerTest
    {
      
        [TestMethod]
        public void HowManyPlayers_PostiveNumber()
        {
            // Arrange
            WriteClass writer = new WriteClass();
            FakeUserInput userInput = new FakeUserInput();
            CreatePlayers createPlayer = new CreatePlayers(writer, userInput);
            int expected = 3;

            // Act
            var actual = createPlayer.HowManyPlayers();
          
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnterNameOfPlayersTest_PlayersName()
        {
            // Arrange
            WriteClass writer = new WriteClass();
            FakeUserInput userInput = new FakeUserInput();
            CreatePlayers createPlayers = new CreatePlayers(writer, userInput);
            
            //Act
            int expected = userInput.GetIntInput();
            var actual = createPlayers.EnterNameOfPlayers(expected);

            //Assert
            Assert.IsTrue(actual.Count == expected);
        }
    }
}
