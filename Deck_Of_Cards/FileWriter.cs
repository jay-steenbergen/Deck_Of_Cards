using System;
using System.Collections.Generic;
using System.Text;

namespace Deck_Of_Cards
{
    class FileWriter
    {
        private readonly IWriter _writer;

        public FileWriter(IWriter writer)
        {
            _writer = writer;
        }

        public void Write()
        {
            _writer.WriteFile();
        }
    }
}
