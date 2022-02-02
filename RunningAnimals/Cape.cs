using RunningAnimals.Interfaces;

namespace RunningAnimals
{
    public class Cape : IEquipable
    {
        public string Name;
        private int _bonusSpeed;
        private float _bonusReward;
        public float Price;

        public Cape(string name, int bonusSpeed, float bonusReward, float price)
        {
            Name = name;
            _bonusSpeed = bonusSpeed;
            _bonusReward = bonusReward;
            Price = price;
        }

        public void Equip(Animal animal)
        {
            animal.cape = this;
        }

        public void UnEquip(Animal animal)
        {
            animal.cape = new Cape("Beginner Cape", 0, 1f, 0);
        }

        public int GetBonusSpeed() => _bonusSpeed;
        public float GetBonusReward() => _bonusReward;
    }
}
