using System;
using System.Collections.Generic;
using System.Text;

namespace Snakes_and_Ladders_Kata
{
    class Dice
    {
        // Generate a random number between 1 and 6
        public int rollDice()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }
    }
}
