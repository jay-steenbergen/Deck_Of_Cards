using System;
using System.Collections.Generic;
using System.Text;

namespace Deck_Of_Cards
{
    class MessageDispatcher
    {
        IWriter writer = null;
        public MessageDispatcher(IWriter writer)
        {
            this.writer = writer;
        }

        public void SendMessage(string message)
        {
            writer.Write(message);
        }
    }
}
