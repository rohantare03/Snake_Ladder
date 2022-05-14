using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class PlayerWinning
    {
        int Player1position = 0;
        int Player2position = 0;
        const int NoPlay = 0, Ladder = 1, Snake = 2;
        const int WinPosition = 100;


        public void PlayerWin()
        {

            while (Player1position < WinPosition && Player2position < WinPosition)
            {
                Random random = new Random();
                int Dice = random.Next(1, 7);

                Random check = new Random();
                int Option = check.Next(0, 3);

                switch (Option)
                {
                    case NoPlay:
                        Console.WriteLine("No Play");
                        break;
                    case Ladder:
                        Player1position += Dice;
                        Console.WriteLine("Player1 reached a Ladder : " + Player1position);
                        break;
                    case Snake:
                        Player1position -= Dice;
                        Console.WriteLine("Player2 got eaten by a Snake : " + Player1position);
                        break;
                    default:
                        Console.WriteLine("Enter a valid input.");
                        break;

                }
                Player1position++;
                Console.WriteLine("Player1 current position is " + Player1position);

                switch (Option)
                {
                    case NoPlay:
                        Console.WriteLine("No Play");
                        break;
                    case Ladder:
                        Player2position += Dice;
                        Console.WriteLine("Player2 reached a Ladder : " + Player2position);
                        break;
                    case Snake:
                        Player2position -= Dice;
                        Console.WriteLine("Player2 got eaten by a Snake : " + Player2position);
                        break;
                    default:
                        Console.WriteLine("Enter a valid input.");
                        break;

                }
                Player2position++;
                Console.WriteLine("Player2 current position is " + Player2position);



            }
            if (Player1position == WinPosition)
            {
                Console.WriteLine("Congratulations!! Player1 won the game.");
            }
            else
            {
                Console.WriteLine("Congratulations!! Player2 won the game.");
            }
        }
    }
}
