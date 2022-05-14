namespace SnakeLadder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a particular number : ");
            Console.WriteLine("1 for Player position.");
            Console.WriteLine("2 for rolling the dice");
            Console.WriteLine("3 for checking player option");
            Console.WriteLine("4 for winning position");
            Console.WriteLine("5 for Win Position 100");
            Console.WriteLine("6 for finding the number of times dice was rolled");
            Console.WriteLine("7 for finding Player Win");

            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 1:
                    PlayerPos playerPosition = new PlayerPos();
                    playerPosition.PlayerPosition();
                    break;
                case 2:
                    DiceRoll roll = new DiceRoll();
                    roll.Dice_Roll();
                    break;
                case 3:
                    PlayerCheck playerCheck = new PlayerCheck();
                    playerCheck.PlayerOption();
                    break;
                case 4:
                    WinningPosition winningPosition = new WinningPosition();
                    winningPosition.WinningPos();
                    break;
                case 5:
                    WinPosition100 winPosition = new WinPosition100();
                    winPosition.WinPosition();
                    break;
                case 6:
                    DiceRollNumber diceRoll = new DiceRollNumber();
                    diceRoll.DiceRoll_Number();
                    break;
                case 7:
                    PlayerWinning playerwin = new PlayerWinning();
                    playerwin.PlayerWin();
                    break;
                default:
                    Console.WriteLine("Enter a valid input");
                    break; 

            }
        }
    }
}
