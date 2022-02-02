namespace RunningAnimals.Animals
{

    public class Dog : Animal
    {   
        public Dog(string name, Cape cape) : base(name, cape)
        {
            Name = name;
            this.cape = cape;
            AnimalName = "Dog";
            MaxSpeed = 12;
        }   
    }
}
