namespace SnakeLadder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a particular number : ");
            Console.WriteLine("1 for Player position.");

            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 1:
                    PlayerPos playerPosition = new PlayerPos();
                    playerPosition.PlayerPosition();
                    break;
            }
        }
    }
}
