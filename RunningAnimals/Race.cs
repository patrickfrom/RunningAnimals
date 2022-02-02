using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RunningAnimals
{
    internal class Race
    {
        public int RaceID;
        public List<Animal> Animals = new List<Animal>();
        private List<int> _traps = new List<int>();
        public Track RaceTrack;
        private Animal _winner;
        private string _log;
        private RaceManager _raceManager;

        public Race(int raceID, List<Animal> rats, Track raceTrack , RaceManager rm)
        {
            RaceID = raceID;
            Animals = rats;
            RaceTrack = raceTrack;
            _raceManager = rm;
        }

        public void ConductRace()
        {
            int trapAmount = RNG.Range(10, 0);

            for (int i = 0; i < trapAmount; i++)
            {
                _traps.Add(RNG.Range(RaceTrack.TrackLength, 1));
            }

            while (GetWinner() == null)
            {
                foreach (Animal animal in Animals)
                {
                    animal.MoveAnimal();

                    foreach (int trap in _traps)
                    {
                        if (trap == animal.Position)
                        {
                            animal.MoveAnimalBackwards();                            
                        }
                    }

                    if (animal.Position >= RaceTrack.TrackLength)
                        _winner = animal;
                }
            }
            logRace();
            _winner = null;
            foreach (Animal animal in Animals)
            {
                animal.ResetAnimal();
            }
        }

        public Animal GetWinner() => _winner;

        public string GetRaceReport() => _log;

        private void logRace()
        {
            _log = "";
            _log += $"Winning Animal: {GetWinner().Name}\n";

            foreach (Animal animal in Animals)
            {
                _log += $"\nName: {animal.Name}\nAnimal Type: {animal.AnimalName}\nPosition: {animal.Position}\n";
            }
        }
    }
}
