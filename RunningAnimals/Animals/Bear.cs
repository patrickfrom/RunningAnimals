using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningAnimals.Animals
{
    public class Bear : Animal
    {
        public Bear(string name, Cape cape) : base(name, cape)
        {
            Name = name;
            this.cape = cape;
            AnimalName = "Bear";
            MaxSpeed = 8;
        }
    }
}
