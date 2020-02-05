
using System;
using System.Collections;
using System.Collections.Generic;
using static Deck_Of_Cards.WriteClass;

namespace Deck_Of_Cards
{
    public class CreatePlayers 
    {
        IWriteClass _writer;
        IUserInput _userInput;
        public CreatePlayers(IWriteClass writer, IUserInput userInput)
        {
            _writer = writer;
            _userInput = userInput;
        }
        public List<Player> listOfPlayers = new List<Player>();

        public int HowManyPlayers()
        {
            /// User enters in the Number of player 
            while (true)
            {
                _writer.WriteLine(Colors.None, "How many players: ");
                var numberOfPlayers =_userInput.GetIntInput();
                if(numberOfPlayers > 0)
                    return numberOfPlayers;
                else 
                    _writer.WriteLine(Colors.Red, "Invalid entry...."); 
                
            }
        }

        public List<Player> EnterNameOfPlayers(int numberOfPlayers )
        {
            /// User can now enter Names of players
            for (int i = 0; i < numberOfPlayers;)
            {
                _writer.Write(Colors.None, "Enter name: ");
                var playerName =_userInput.GetStringInput();
                if (playerName.Length <= 0)
                {
                    _writer.WriteLine(Colors.Red, "Invalid Entry....");
                }
                else
                {
                    listOfPlayers.Add(new Player(playerName, i));
                    i++;
                }
            }
            return listOfPlayers;
        }

    }
}
