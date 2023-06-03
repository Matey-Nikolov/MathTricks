namespace MathTricks
{
    public class Program
    {
<<<<<<< Updated upstream
            /*
            private static GameBoard board;
            private static uint n;
            private static uint m;
            */

        static void Main(string[] args)
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

            int width;
            int height;

            do
            {
                Console.Write("Enter the height of the board (minimum 4): ");
            } 
            
            while (!int.TryParse(Console.ReadLine(), out height) || height < 4);

            do
            {
                Console.Write("Enter the width of the board (minimum 4): ");
            } 
            
            while (!int.TryParse(Console.ReadLine(), out width) || width < 4);

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
            Console.Write("    ");
            for (int col = 0; col < width; col++)
            {
                if (col == 0)
                    Console.Write($"{col + 1,3}");
                else
                    Console.Write($"{col + 1,6}");
            }
            Console.WriteLine();

            // Display horizontal line
            Console.Write("   ");
            for (int col = 0; col < width; col++)
            {
                Console.Write("------");
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
                    Console.Write("------");
                }
                Console.WriteLine();
            }
=======
        private static GameBoard board;
        private static int inputN;
        private static int inputM;
        private static string[,] boardMatrix;

        static void Main()
        {
            do
            {
                Console.Write("Enter the height of the board (minimum 4 and maximum 15): ");
                if (!int.TryParse(Console.ReadLine(), out inputM) || inputM < 4 || inputM > 15)
                {
                    Console.WriteLine("Invalid input. Height must be a positive integer greater than or equal to 4. \r\n");
                }

            } while (inputM < 4 || inputM !> 15); 

            do
            {
                Console.Write("Enter the width of the board (minimum 4 and maximum 15): ");
                if (!int.TryParse(Console.ReadLine(), out inputN) || inputN < 4 || inputM > 15)
                {
                    Console.WriteLine("Invalid input. Width must be a positive integer greater than or equal to 4. \r\n");
                }

            } while (inputN < 4 || inputN !> 15);


            Console.Clear();
            Console.WriteLine("MathTricks");
            Console.WriteLine("-----------------");


            try
            {
                board = new GameBoard(inputN, inputM);
            }

            catch (ArgumentOutOfRangeException exp)
            {
                Console.WriteLine(exp.Message);
            }

            boardMatrix = board.CreateBoard();
            board.DisplayBoard(boardMatrix);
>>>>>>> Stashed changes
        }
    }
}