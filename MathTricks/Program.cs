namespace MathTricks
{
    public class Program
    {
        private static GameBoard board;
        private static uint n;
        private static uint m;

        static void Main()
        {
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
        }

        /*
        private static void Validation(bool resultN, bool resultM)
        {
            if (!resultN && !resultM)
            {
                Console.WriteLine("The inputs is not a valid positive integers.");
            }
        }*/

    }
}