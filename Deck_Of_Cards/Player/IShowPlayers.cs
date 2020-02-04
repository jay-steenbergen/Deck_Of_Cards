using System.Collections.Generic;

namespace Deck_Of_Cards
{
    public interface IShowPlayers
    {
        List<string> GetPlayerNames(List<Player> listOfPlayers);
        void PrintHand(List<Player> listOfPlayers);
    }
}