using System.Collections;
using System.Collections.Generic;

namespace Deck_Of_Cards
{
    public class Player
    {
        private int Id { get;  set; }
        public string Name {  get; private set; }

        public List<string> Hand;

        public Player(string name, int id)
        {
            Id = id;
            Name = name;
            Hand = new List<string>();
        }
      
    }
}
