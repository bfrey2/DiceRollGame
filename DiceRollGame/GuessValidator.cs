using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRollGame
{
    static class GuessValidator
    {
        public static bool IsValid(string guess)
        {
            return int.TryParse(guess, out _);
        }
    }
}
