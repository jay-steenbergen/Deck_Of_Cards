using System.Collections.Generic;

namespace Deck_Of_Cards
{
    public interface IDeal
    {
        string dealOneCard(List<KeyValuePair<string, string>> shuffledDeck);
    }
}