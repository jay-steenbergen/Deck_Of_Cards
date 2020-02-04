using System.Collections.Generic;

namespace Deck_Of_Cards
{
    public interface IWriteClass
    {
        void Clear();
        void Deliminter();
        void Write(WriteClass.Colors color, string body);
        void WriteLine(WriteClass.Colors color, string body);
        void WriteList(WriteClass.Colors color, List<string> list);
    }
}