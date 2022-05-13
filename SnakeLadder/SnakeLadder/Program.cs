namespace SnakeLadder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a particular number : ");
            Console.WriteLine("1 for Player position.");
            Console.WriteLine("2 for rolling the dice");

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

            }
        }
    }
}
