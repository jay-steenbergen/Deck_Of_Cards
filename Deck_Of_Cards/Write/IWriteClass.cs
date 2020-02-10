using System.Collections.Generic;
using static Deck_Of_Cards.WriteClass;

namespace Deck_Of_Cards
{
    public interface IWriteClass
    {
        void BlankLine();
        void Clear();
        void ReadLine();
        string Input();
        void Deliminter();
        void Write(Colors color, string body);
        void WriteLine(Colors color, string body);
        void WriteList(Colors color, List<string> list);
    }
}