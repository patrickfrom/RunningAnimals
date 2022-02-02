namespace RunningAnimals.Animals
{

    public class Duck : Animal
    {   
        public Duck(string name, Cape cape) : base(name, cape)
        {
            Name = name;
            this.cape = cape;
            AnimalName = "Duck";
            MaxSpeed = 4;
        }   
    }
}
