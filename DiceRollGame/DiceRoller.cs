using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRollGame
{
    static class DiceRoller
    {
        private static readonly Random random = new Random();
        private const int DefaultSides = 6;

        public static int RollDice()
        {
            return random.Next(1, DefaultSides + 1);
        }
    }
}
