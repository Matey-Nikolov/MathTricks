namespace MathTricks
{
    public class GameBoard
    {
        Random rnd = new Random();

        private int x;
        private int y;

        private string[,] boardMatrix;

        public string[,] BoardMatrix
        {
            get { return boardMatrix; }
            set { boardMatrix = value; }
        }


        public int X
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

        public int Y
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

        public GameBoard(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string[,] CreateBoard()
        {

            BoardMatrix = new string[y, x];

            for (uint i = 0; i < x; i++)
            {
                for (uint j = 0; j < y; j++)
                {
                    int randomNegativeNumber = rnd.Next(1, (int)y + 1);
                    int randomNumber2 = rnd.Next(0, (int)y + 1);

                    string[] mathFunctions = new string[] { "*2", "/2", $"-{randomNegativeNumber}", $" {randomNumber2}" };

                    if (i == 0 && j == 0)
                    {
                        BoardMatrix[j, i] = " 0";
                    }
                    else if (i == x - 1 && j == y - 1)
                    {
                        BoardMatrix[j, i] = " 0";
                    }
                    else
                    {
                        BoardMatrix[j, i] = mathFunctions[rnd.Next(0, 4)].ToString();
                    }
                }
            }

            return BoardMatrix;
        }

        public void DisplayBoard(string[,] board)
        {
            Console.Write("    ");
            for (int col = 0; col < x; col++)
            {
                if (col == 0)
                    Console.Write($"{col + 1,3}");
                else
                    Console.Write($"{col + 1,6}");
            }
            Console.WriteLine();

            Console.Write("   ");
            for (int col = 0; col < x; col++)
            {
                Console.Write("------");
            }
            Console.WriteLine();

            for (int row = 0; row < y; row++)
            {
                Console.Write($"{row + 1,2} |");

                for (int col = 0; col < x; col++)
                {
                    if (row == 0 && col == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write($" {board[row, col],-3} ");
                        Console.ResetColor();
                        Console.Write("|");
                    }
                    else if (row == y - 1 && col == x - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Write($" {board[row, col],-3} ");
                        Console.ResetColor();
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write($" {board[row, col],-3} |");
                    }
                }

                Console.WriteLine();

                Console.Write("   ");
                for (int col = 0; col < x; col++)
                {
                    Console.Write("------");
                }
                Console.WriteLine();

                Console.ResetColor();
            }
        }

        public void Move(Player currentPlayer)
        {
            while (!IsGameOver())
            {
                Console.WriteLine($"Player {currentPlayer.Name}'s turn");
                Console.Write("Enter the row and column to move (e.g., '2, 3'): ");
             
                string[] inputParts = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                // Ok
                if (inputParts.Length != 2 || !int.TryParse(inputParts[0], out int row) || !int.TryParse(inputParts[1], out int col))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
                else if (row < 1 || row > y || col < 1 || col > x)
                {
                    Console.WriteLine("Invalid coordinates. Please try again.");
                    continue;
                }

                row--;
                col--;

                if (currentPlayer.X_PlayerMove == row && currentPlayer.Y_PlayerMove == col)
                {
                    Console.WriteLine("Invalid coordinates. Please try again.");
                    continue;
                }

                string name = boardMatrix[row, col];

                Console.WriteLine(name);

                DisplayBoard(BoardMatrix);
            }

            Console.WriteLine("Game over!");
        }

        public bool IsGameOver()
        {
            return false;
        }
    }
}
