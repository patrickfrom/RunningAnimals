using System.Collections.Generic;
using System.Windows.Forms;
using RunningAnimals.Animals;

namespace RunningAnimals
{
    internal class RaceManager
    {
        public List<Track> Tracks = new List<Track>();
        public List<Player> Players = new List<Player>();
        public List<Race> Races = new List<Race>();
        public List<Animal> Animals = new List<Animal>();
        public Bookmaker bookmaker;

        public RaceManager(Bookmaker bookmaker)
        {
            this.bookmaker = bookmaker;
        }

        public Race CreateRace(int raceID, List<Animal> animals, Track track)
        {
            Race race = new Race(raceID, animals, track, this);
            Races.Add(race);

            return race;
        }

        public Track CreateTrack(string name, int tracklength)
        {
            Track track = new Track(name, tracklength);
            Tracks.Add(track);
            
            return track;
        }

        public Cape AddCape(Cape cape, Player player)
        {
            if(player.Money >= cape.Price)
            {
                player.Money -= cape.Price;
            }
            else
            {
                return new Cape("Beginner Cape", 0, 1f, 0f);
            }

            return cape;
        }
        
        public Race ConductRace(Race race, RichTextBox winningPlayerLabel)
        {
            for (int i = 0; i < Players.Count; i++)
            {
                bookmaker.PlaceBet(Races[0], Animals[i], Players[i], RNG.Range(10, 5));
            }
            
            race.ConductRace();
            bookmaker.PayOutWinnings(Races[0], winningPlayerLabel);
            return race;
        }

        public string ViewRaceReport(Race race) => race.GetRaceReport();

        
        public Animal CreateAnimal(Animal animal)
        {
            Animals.Add(animal);

            return animal;
        }

        public Player CreatePlayer(string name, int money)
        {
            Player player = new Player(name, money);
            Players.Add(player);

            return player;
        }
    }
}
