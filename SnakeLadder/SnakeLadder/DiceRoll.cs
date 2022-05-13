using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class DiceRoll
    {
        public void Dice_Roll()
        {
            int PlayerPosition = 0;
            Random check = new Random();
            int dice = check.Next(1, 7);

            Console.WriteLine( "Starting Position of player is " + PlayerPosition );
            Console.WriteLine("The number after rolling the dice is " + dice);

        }
    }
}
