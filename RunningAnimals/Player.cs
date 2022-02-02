using System.Collections.Generic;

namespace RunningAnimals
{
    internal class Player
    {
        public string Name;
        public float Money;
        public List<Bet> Bets = new List<Bet>();

        public Player(string name, float money)
        {
            Name = name;
            Money = money;
        }
    }
}
