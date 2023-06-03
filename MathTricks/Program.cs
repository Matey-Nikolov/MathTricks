namespace MathTricks
{
    public class Program
    {
        private static GameBoard board;
        private static uint n;
        private static uint m;
        private static string[,] boardMatrix;

        static void Main()
        {
            Console.Write("Enter a positive number for x:");
            bool resultN = uint.TryParse(Console.ReadLine(), out n);
            Console.Write("Enter a positive number for y:");
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

            boardMatrix = board.CreateBoard();
            board.DisplayBoard(boardMatrix);

            /*
            int rows = boardMatrix.GetLength(0);
            int columns = boardMatrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(boardMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
        }
    }
}