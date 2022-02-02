using System.Collections.Generic;
using System.Windows.Forms;

namespace RunningAnimals
{
    internal class Bookmaker
    {
        public List<Bet> Bets = new List<Bet>();
        
        public Bet PlaceBet(Race race, Animal animal, Player player, float amount)
        {
            Bet newBet = new Bet(amount, player, race, animal);
            player.Money -= amount;

            Bets.Add(newBet);
            return newBet;
        }

        public void PayOutWinnings(Race race, RichTextBox winningPlayerLabel) {
            foreach (Bet bet in Bets)
            {
                bet.PayWinnings(winningPlayerLabel);
            }
        }
    }
}
