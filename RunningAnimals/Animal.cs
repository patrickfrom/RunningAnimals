namespace RunningAnimals
{
    public abstract class Animal
    {
        public string Name;
        public string AnimalName;
        public int MaxSpeed;
        public Cape cape;

        private int _position;
        public int Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }

        public Animal(string name, Cape cape)
        {
            Name = name;
            this.cape = cape;
        }

        public void ResetAnimal()
        {
            Position = 0;
        }

        public virtual int MoveAnimal()
        {
            int MoveAmount = RNG.Range(MaxSpeed+cape.GetBonusSpeed(), 1);

            Position += MoveAmount;

            return MoveAmount;
        }

        public virtual int MoveAnimalBackwards()
        {
            int MoveAmount = RNG.Range(5, 1);

            Position -= MoveAmount;

            return MoveAmount;
        }
    }
}
