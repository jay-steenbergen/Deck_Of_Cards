using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deck_Of_Cards.UnitTest
{
    [TestClass()]
    public class DeckTest
    {
        [TestMethod]
        public void CanCreateDeck_DeckIsCreated_ReturnCards()
        {
            //Arrange
            var deckOfCards = new Deck();
            
            //Act
            var result = deckOfCards.createDeck();
            //Assert
            Assert.IsTrue(result.Count == 52);
        }

    }
}
