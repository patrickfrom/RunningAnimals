using System;
using System.Windows.Forms;

namespace RunningAnimals
{
    internal class Bet
    {
        private float _money;
        private Player _player;
        private Race _race;
        private Animal _animal;

        public Bet(float money, Player player, Race race, Animal animal)
        {
            _money = money;
            _player = player;
            _race = race;
            _animal = animal;
        }

        public void PayWinnings(RichTextBox winningPlayerLabel)
        {
            float earning = (_money * 2) * _animal.cape.GetBonusReward();
            if(_race.GetWinner() == _animal)
            {
                _player.Money += earning;
                winningPlayerLabel.Text = $"Winning Player: {_player.Name}\nEarned: ${earning}";
            }
        }

    }
}
