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

            }
        }
    }
}
