using System;
using System.Collections.Generic;

namespace RunningAnimals.Interfaces
{
    public interface IEquipable
    {
        void Equip(Animal animal);

        void UnEquip(Animal animal);

    }
}
