using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class DiceRollNumber
    {
        int Playerposition = 0;
        const int NoPlay = 0, Ladder = 1, Snake = 2;
        int count = 0;


        public void DiceRoll_Number() 
        {

            while (Playerposition <= 100)
            {

                Random random = new Random();
                int Dice = random.Next(1, 7);
                Console.WriteLine("Dice number : " + Dice);

                Random check = new Random();
                int Option = check.Next(0, 3);

                switch (Option)
                {
                    case NoPlay:
                        Console.WriteLine("No Play");
                        break;
                    case Ladder:
                        Playerposition += Dice;
                        Console.WriteLine("You reached a Ladder : " + Playerposition);
                        break;
                    case Snake:
                        Playerposition -= Dice;
                        Console.WriteLine("You got eaten by a Snake : " + Playerposition);
                        break;
                    default:
                        Console.WriteLine("Enter a valid input.");
                        break;

                }
                count++;
                Playerposition++;


                if (Playerposition < 0)
                {
                    Playerposition = 0;
                }
            }
            Console.WriteLine("Number of times the dice was rolled : " + count);
        }
    }
}
