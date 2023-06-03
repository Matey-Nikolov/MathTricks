namespace MathTricks
{
    public class Program
    {
        private static GameBoard board;
        private static Player player;
        private static List<Player> players = new List<Player>();

        private static List<Point> player1;
        private static List<Point> player2;

        private static int inputN;
        private static int inputM;
        private static string[,] boardMatrix;

        static void Main()
        {
            Console.WriteLine("MathTricks");
            Console.WriteLine("-----------------");

            do
            {
                Console.Write("Enter the height of the board (minimum 4 and maximum 15): ");
                if (!int.TryParse(Console.ReadLine(), out inputM) || inputM < 4 || inputM > 15)
                {
                    Console.WriteLine("Invalid input. Height must be a positive integer greater than or equal to 4. \r\n");
                }

            } while (inputM < 4 || inputM! > 15);

            do
            {
                Console.Write("Enter the width of the board (minimum 4 and maximum 15): ");
                if (!int.TryParse(Console.ReadLine(), out inputN) || inputN < 4 || inputM > 15)
                {
                    Console.WriteLine("Invalid input. Width must be a positive integer greater than or equal to 4. \r\n");
                }

            } while (inputN < 4 || inputN! > 15);

            Console.Clear();

            try
            {
                board = new GameBoard(inputN, inputM);
                boardMatrix = board.CreateBoard();
            }
            catch (ArgumentOutOfRangeException exp)
            { 
                Console.WriteLine(exp.Message);
            }

            Console.Write("Enter a player name 1: ");
            string name = Console.ReadLine();
            player = new Player(name, 0, 0);

            players.Add(player);

            Console.Write("Enter a player name 2: ");
            name = Console.ReadLine();
            player = new Player(name, inputN, inputM);

            players.Add(player);

            Console.Clear();

            board.DisplayBoard(boardMatrix);


            foreach (var player in players)
            {
                board.Move(player);
            }
        }
    }
}