using System;

namespace RunningAnimals
{
    static class RNG
    {
        private static Random _rng = new Random();

        public static int Range(int upper, int lower) => _rng.Next(lower, upper);
    } 
}
