using System.Collections.Generic;

namespace Deck_Of_Cards
{
    public interface IMenu
    {
        void GameMenu(List<Player> listOfPlayers, List<KeyValuePair<string, string>> shuffledDeck);
    }
}