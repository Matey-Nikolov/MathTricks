namespace MathTricks
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
            private static GameBoard board;
            private static uint n;
            private static uint m;
            */

            static void Main()
            {
                /*

                bool resultN = uint.TryParse(Console.ReadLine(), out n);
                bool resultM = uint.TryParse(Console.ReadLine(), out m);
                //Validation(resultN, resultM);

                try
                {

                    board = new GameBoard(n, m);
                }
                catch(ArgumentOutOfRangeException exp)
                { 
                    Console.WriteLine(exp.Message);
                }
            }*/

                /*
                private static void Validation(bool resultN, bool resultM)
                {
                    if (!resultN && !resultM)
                    {
                        Console.WriteLine("The inputs is not a valid positive integers.");
                    }
                }*/

                int height, width;

                do
                {
                    Console.Write("Enter the height of the board (minimum 4): ");
                } while (!int.TryParse(Console.ReadLine(), out height) || height < 4);

                do
                {
                    Console.Write("Enter the width of the board (minimum 4): ");
                } while (!int.TryParse(Console.ReadLine(), out width) || width < 4);

                Console.Clear();
                Console.WriteLine("Matrix Board Game");
                Console.WriteLine("-----------------");

                // Create the board matrix
                char[,] board = new char[height, width];

                // Fill the board with empty spaces
                for (int row = 0; row < height; row++)
                {
                    for (int col = 0; col < width; col++)
                    {
                        board[row, col] = ' ';
                    }
                }

                // Display the board
                DisplayBoard(board);
            }

            static void DisplayBoard(char[,] board)
            {
                int height = board.GetLength(0);
                int width = board.GetLength(1);

                // Display column headers
                Console.Write("   ");
                for (int col = 0; col < width; col++)
                {
                    Console.Write($" {col + 1,3}");
                }
                Console.WriteLine();

                // Display horizontal line
                Console.Write("   ");
                for (int col = 0; col < width; col++)
                {
                    Console.Write("----");
                }
                Console.WriteLine();

                // Display rows with board content
                for (int row = 0; row < height; row++)
                {
                    Console.Write($"{row + 1,2} |");

                    for (int col = 0; col < width; col++)
                    {
                        Console.Write($" {board[row, col],-3} |");
                    }

                    Console.WriteLine();

                    // Display horizontal line
                    Console.Write("   ");
                    for (int col = 0; col < width; col++)
                    {
                        Console.Write("----");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}