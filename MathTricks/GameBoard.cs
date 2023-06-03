using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTricks
{
    public class GameBoard
    {
        Random rnd = new Random();

        private uint x;
        private uint y;

        private string[,] boardMatrix;

        public string[,] BoardMatrix
        {
            get { return boardMatrix; }
            set { boardMatrix = value; }
        }


        public uint X
        {
            get { return x; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Not allow negative numbers.");
                }
                else if (value < 4)
                {
                    throw new ArgumentOutOfRangeException("Min boards size is 4 by 4.");
                }

                x = value; 
            }
        }

        public uint Y
        {
            get { return y; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Not allow negative numbers.");
                }
                else if (value < 4)
                {
                    throw new ArgumentOutOfRangeException("Min boards size is 4 by 4.");
                }

                y = value;
            }
        }

        public GameBoard(uint x, uint y) 
        { 
            X = x;
            Y = y;
        }

        public string[,] CreateBoard()
        {

            BoardMatrix = new string[y, x];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    int randomNegativeNumber = rnd.Next(1, (int)y + 1);
                    int randomNumber2 = rnd.Next(0, (int)y + 1);

                    string[] mathFunctions = new string[] { "*2", "/2", $"-{randomNegativeNumber}", $"{randomNumber2}" };

                    if (i == 0 && j == 0)
                    {
                        BoardMatrix[j, i] = "0";
                    }
                    else if (i == x - 1 && j == y - 1)
                    {
                        BoardMatrix[j, i] = "0";
                    }
                    else
                    {
                        BoardMatrix[j, i] = mathFunctions[rnd.Next(0, 4)].ToString(); // Generates a random number between 1 and 10 and converts it to a string
                    }
                }
            }

            return BoardMatrix;
        }

        public void DisplayBoard(string[,] board)
        {
            // Display column headers
            Console.Write("    ");
            for (int col = 0; col < x; col++)
            {
                if (col == 0)
                    Console.Write($"{col + 1,3}");
                else
                    Console.Write($"{col + 1,6}");
            }
            Console.WriteLine();

            // Display horizontal line
            Console.Write("   ");
            for (int col = 0; col < x; col++)
            {
                Console.Write("------");
            }
            Console.WriteLine();

            // Display rows with board content
            for (int row = 0; row < y; row++)
            {
                Console.Write($"{row + 1,2} |");

                for (int col = 0; col < x; col++)
                {
                    Console.Write($" {board[row, col],-3} |");
                }

                Console.WriteLine();

                // Display horizontal line
                Console.Write("   ");
                for (int col = 0; col < x; col++)
                {
                    Console.Write("------");
                }
                Console.WriteLine();
            }
        }
    }
}
