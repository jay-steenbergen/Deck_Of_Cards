using System;
using System.Collections.Generic;
using static Deck_Of_Cards.WriteClass;

namespace Deck_Of_Cards
{
    public class PlayersHand : IPlayersHand
    {
        IWriteClass _writer;
        IUserInput _userInput;
        public PlayersHand(IWriteClass writer, IUserInput userInput)
        {
            _writer = writer;
            _userInput = userInput;
        }
        public void AddCardToHand(string deltCard, List<Player> listOfPlayers)
        {
            int count = 0;
            var flag = true;
            while (flag)
            {
                _writer.WriteLine(Colors.None, "What player do you want to deal: ");
                string playerName = _userInput.GetStringInput();
                foreach (var player in listOfPlayers)
                {
                    if (playerName.Length <= 0)
                    {
                        _writer.WriteLine(Colors.Red, "No player found...\n");
                        break;
                    }
                    else if (string.Equals(player.Name, playerName, StringComparison.CurrentCultureIgnoreCase))
                    {
                        player.Hand.Add(deltCard);

                        flag = false;
                        break;
                    }
                    else if (count == listOfPlayers.Count - 1)
                    {
                        _writer.WriteLine(Colors.Red, "No player found...\n");
                    }
                    count++;
                }
            }
          
        }
    }
}

