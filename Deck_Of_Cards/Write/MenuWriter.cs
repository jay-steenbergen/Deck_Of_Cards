using System;
using System.Collections.Generic;
using System.Text;
using static Deck_Of_Cards.WriteClass;

namespace Deck_Of_Cards
{
    class MenuWriter : IMenuWriter
    {
        IWriteClass _writer;
        IDeal _deal;
        IPlayersHand _playersHand;
        IShowPlayers _showPlayers;
        public MenuWriter(IWriteClass writer, IDeal deal, IPlayersHand playersHand, IShowPlayers showPlayer)
        {
            _writer = writer;
            _deal = deal;
            _playersHand = playersHand;
            _showPlayers = showPlayer;
        }
        public void WriteBanner(List<Player> listOfPlayers)
        {
            _writer.Clear();
            _writer.Deliminter();
            _writer.Write(Colors.Blue, "Deck Of Cards");
            _writer.Write(Colors.Blue, "Players: ");
            var getPlayerNames = _showPlayers.GetPlayerNames(listOfPlayers); //// Display Player names on screen
            _writer.WriteList(Colors.Cyan, getPlayerNames);
            _writer.BlankLine();
            _writer.Deliminter();
        }
        public void WriteYes(List<Player> listOfPlayers, List<KeyValuePair<string, string>> shuffledDeck)
        {
            var deltCard = _deal.dealOneCard(shuffledDeck);

            _playersHand.AddCardToHand(deltCard, listOfPlayers);

            _writer.Write(Colors.None, "\nDelt the ");
            _writer.WriteLine(Colors.Magenta, deltCard);
            _writer.WriteLine(Colors.None, "\nYour hand:");
            _showPlayers.PrintHand(listOfPlayers);
            _writer.WriteLine(Colors.None, "\nPress enter....");
            _writer.ReadLine();
        }
        public void WriteNo(List<Player> listOfPlayers)
        {
            _writer.WriteLine(Colors.None, "You hand is: \n");
            _writer.Write(Colors.Red, "Your final hand \n\n");
            _showPlayers.PrintHand(listOfPlayers);
        }
        public void WriteDefualt()
        {
            _writer.WriteLine(Colors.Yellow, "\nInvalid input \nPress enter....");
            _writer.ReadLine();
        }
    }
}
