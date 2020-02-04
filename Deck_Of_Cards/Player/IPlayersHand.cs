using System.Collections.Generic;

namespace Deck_Of_Cards
{
    public interface IPlayersHand
    {
        void AddCardToHand(string deltCard, List<Player> listOfPlayers);
    }
}