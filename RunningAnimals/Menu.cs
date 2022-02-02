using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RunningAnimals.Animals;

namespace RunningAnimals
{
    public partial class Menu : Form
    {
        RaceManager raceManager;
        public Menu()
        {
            InitializeComponent();
            AnimalComboChoice.SelectedIndex = 0;
            CapeComboChoice.SelectedIndex = 0;

            raceManager = new RaceManager(new Bookmaker());
            Game();
        }

        void Game()
        {

            Cape BeginnerCape = new Cape("Beginner Cape", 0, 1f, 0f);

            raceManager.CreateTrack("Tokyo", 300);
            raceManager.CreateTrack("Akina - Mount Haruna", 149);
            GenerateTracks();

            raceManager.CreatePlayer("Sagiri", RNG.Range(200, 100));
            raceManager.CreatePlayer("Megumin", RNG.Range(200, 100));
            raceManager.CreatePlayer("Klee", RNG.Range(200, 100));

            raceManager.CreateAnimal(new Duck("Gary", BeginnerCape));
            raceManager.CreateAnimal(new Dog("Larry", BeginnerCape));
            raceManager.CreateAnimal(new Bear("Berry", BeginnerCape));

            AnimalListText.Text = "Animals\n\n";
            foreach (Animal animal in raceManager.Animals)
            {
                AnimalListText.Text += $"Name: {animal.Name}\nType: {animal.AnimalName}\nCape: {animal.cape.Name}\n\n";
            }
        }

        void GenerateTracks()
        {
            foreach (Track track in raceManager.Tracks)
            {
                TrackComboChoice.Items.Add($"Track: {track.Name} Length: {track.TrackLength}");
            }
            TrackComboChoice.SelectedIndex = 0;
        }

        private void CreatePlayerButton_Click(object sender, EventArgs e)
        {
            Animal animal = null;
            Cape cape = null;

            PlayerCreationPanel.Visible = false;
            Player player = raceManager.CreatePlayer(PlayerNameInput.Text, 100);

            switch (CapeComboChoice.SelectedIndex)
            {
                case 0:
                    cape = raceManager.AddCape(new Cape("Beginner Cape", 0, 1f, 0f), player);
                    break;
                case 1:
                    cape = raceManager.AddCape(new Cape("Baby Cape", 2, 1.3f, 25f), player);
                    break;
                case 2:
                    cape = raceManager.AddCape(new Cape("Super Cape", 5, 3f, 50f), player);
                    break;
                case 3:
                    cape = raceManager.AddCape(new Cape("God Cape", 10000, 10000f, 100f), player);
                    break;
                default:
                    break;
            }

            switch (AnimalComboChoice.SelectedItem)
            {
                case "Bear":
                    animal = raceManager.CreateAnimal(new Bear("Mr Bear", cape));
                    break;
                case "Dog":
                    animal = raceManager.CreateAnimal(new Dog("Mr Husky", cape));
                    break;
                case "Duck":
                    animal = raceManager.CreateAnimal(new Duck("Anders And", cape));
                    break;
                default:
                    break;
            }

            AnimalListText.Text += $"Name: {animal.Name}\nType: {animal.AnimalName}\nCape: {animal.cape.Name}\n\n";
            TrackNameLabel.Text = $"Track: {raceManager.Tracks[TrackComboChoice.SelectedIndex].Name}";

            PlayerNameLabel.Text = player.Name;
            AnimalBetLabel.Text = $"{animal.Name}\nBet Amount: {BetAmountInput.Text}";

            if(player.Money > 0)
                player.Money -= float.Parse(BetAmountInput.Text);

            MoneyLabel.Text = $"${player.Money}";

            AnimalPictureBox.ImageLocation = @"../../Images\" + animal.AnimalName.ToLower() + ".png";

            PlayerInfoPanel.Visible = true;
            TrackNameLabel.Visible = true;
            StartRaceButton.Visible = true;

            raceManager.CreateRace(0, raceManager.Animals, raceManager.Tracks[TrackComboChoice.SelectedIndex]);
            raceManager.bookmaker.PlaceBet(raceManager.Races[0], animal, player, float.Parse(BetAmountInput.Text));
        }

        private void StartRace_click(object sender, EventArgs e)
        {
            raceManager.ConductRace(raceManager.Races[0], WinningPlayerLabel);
            WinningPlayerLabel.Text = raceManager.ViewRaceReport(raceManager.Races[0]);
        }
    }
}
