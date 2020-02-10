using System.Collections.Generic;

namespace Deck_Of_Cards
{
    public interface IMenuWriter
    {
        void WriteDefualt();
        void WriteBanner(List<Player> listOfPlayers);
        void WriteNo(List<Player> listOfPlayers);
        void WriteYes(List<Player> listOfPlayers, List<KeyValuePair<string, string>> shuffledDeck);
    }
}