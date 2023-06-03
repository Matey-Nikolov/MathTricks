namespace MathTricks
{
    public class Program
    {
        private static GameBoard board;
        private static int inputN;
        private static int inputM;
        private static string[,] boardMatrix;

        static void Main()
        {
            /*
            Console.Write("Enter a positive number for x:");
            bool resultN = uint.TryParse(Console.ReadLine(), out inputN);


            Console.Write("Enter a positive number for y:");
            bool resultM = uint.TryParse(Console.ReadLine(), out inputM);
            */
            try
            {
                Console.Write("Enter a positive number for x:");
                inputN = int.Parse(Console.ReadLine());

                Console.Write("Enter a positive number for y:");
                inputM = int.Parse(Console.ReadLine());

                board = new GameBoard(inputN, inputM);

                boardMatrix = board.CreateBoard();
                board.DisplayBoard(boardMatrix);

            }
            catch (ArgumentOutOfRangeException exp)
            { 
                Console.WriteLine(exp.Message);
            }
        }
    }
}