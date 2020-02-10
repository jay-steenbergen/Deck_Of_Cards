using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deck_Of_Cards.UnitTest
{
    public class ZeroFakeUserInput : IUserInput
    {
        public int GetIntInput()
        {
            return 0;
        }
        public string GetStringInput()
        {
            return "Test";
        }
    }
    [TestClass]
    public class UserInputTest 
    {
        [TestMethod]
        public void GetIntInput_ReturnIntInput()
        {
            // Arrange
            WriteClass writer = new WriteClass();
            UserInput userInput = new UserInput(writer);
            Console.WriteLine("3");
            var actual = userInput.GetIntInput();
            // Act

            var expected = 3;
            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetIntInput_ReturnZeroInput()
        {
            // Arrange
            WriteClass writer = new WriteClass();
            ZeroFakeUserInput fakeInput = new ZeroFakeUserInput();
            UserInput userInput = new UserInput(writer);
            // Act
            var actual = userInput.GetIntInput();
            userInput.GetStringInput();
            var expected = 0;
            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetStringInput_ReturnStringInput()
        {
            // Arrange
            FakeUserInput fakeInput = new FakeUserInput();
            // Act
            var actual = fakeInput.GetStringInput();
            var expected = "Test";
            // Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
