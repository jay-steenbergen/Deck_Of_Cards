using System;
using System.Collections.Generic;
using static Deck_Of_Cards.WriteClass;

namespace Deck_Of_Cards
{
    public class ShowPlayers : IShowPlayers
    {
        IWriteClass _writer;
        public ShowPlayers(IWriteClass writer)
        {
            _writer = writer;
        }
        public void PrintHand(List<Player> listOfPlayers)
        {
            foreach (var player in listOfPlayers)
            {
                _writer.BlankLine();
                _writer.WriteLine(Colors.None, player.Name);
                _writer.WriteLine(Colors.Cyan, "-----------");
                foreach (var card in player.Hand)
                {
                    _writer.WriteLine(Colors.Cyan, card);
                }
            };
        }
        public List<string> GetPlayerNames(List<Player> listOfPlayers)
        {
            var listOfNames = new List<string>();
            foreach (var player in listOfPlayers)
            {
                listOfNames.Add(player.Name);
            };
            return listOfNames;
        }
    }
}
