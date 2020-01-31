using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Deck_Of_Cards.UnitTest
{
    [TestClass]
    class ProgramTest
    {
        [TestMethod]
        [InlineData("y","n","diff")]
        public void ProgramTest_WhileLoopTrue_ProgramRuns(string y, string n, string diff)
        {
            var mockProgram = new Program();
            
        }
        //[TestMethod]
        //public void ProgramTest_WhileLoopFalse_ProgramStops()
        //{ }
        //[TestMethod]
        //public void ProgramTest_InputIsY_EntersIf()
        //{

        //}
        //[TestMethod]
        //public void ProgramTest_InputIsN_EntersElseIf()
        //{ }
        //[TestMethod]
        //public void ProgramTest_InputIsInvalid_EntersElse()
        //{
        //    //Arrange
        //    var program = new ProgramTest();
        //    var mockDeck = new Deck();
        //    mockDeck.createDeck();
            
        //    //Act
           
        //    //Assert
        //    Assert.AreEqual("\nInvalid input \nPress enter....");
        //}

    }
}
