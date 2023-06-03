using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTricks
{
    internal class GameBoard
    {
        private uint x;
        private uint y;

<<<<<<< Updated upstream
        public uint X
=======
        private int x;
        private int y;
        private string[,] board; // Board matrix
        private bool[,] visitedCells; // Visited cells matrix
        private int currentPlayer; // Current player (1 or 2)


        private string[,] boardMatrix;

        public string[,] BoardMatrix
        {
            get { return boardMatrix; }
            set { boardMatrix = value; }
        }


        public int X
>>>>>>> Stashed changes
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

                x = value;
            }
        }

        public GameBoard(uint x, uint y)
        {
            X = x;
            Y = y;
            visitedCells = new bool[y, x];
            currentPlayer = 1;
        }
<<<<<<< Updated upstream
=======

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
                        BoardMatrix[j, i] = mathFunctions[rnd.Next(0, 4)].ToString(); // Generates a random number between 1 and 10 and converts it to a string
                    }
                }
            }


            return BoardMatrix;
        }
<<<<<<< Updated upstream

=======
        private static void SetCellColor(bool isVisited)
        {
            if (isVisited)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black; // Set unvisited cell's foreground color
                Console.BackgroundColor = ConsoleColor.Gray; // Set unvisited cell's background color
            }
        }

        /*
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
                    // Color the (0, 0) cell with red foreground and yellow background
=======
                    SetCellColor(VisitedCells[row, col]); // Set cell color based on visited status

                    if (row == 0 && col == 0)
                    {
                        VisitedCells[row, col] = true;
                      
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Yellow; 

                        Console.Write($" {board[row, col],-3} ");

                        Console.ResetColor();
                        Console.Write("|");
                    }
                    else if (row == y - 1 && col == x - 1)
                    {
                        VisitedCells[row, col] = true;

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
        */

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
                    SetCellColor(VisitedCells[row, col]); // Set cell color based on visited status

>>>>>>> Stashed changes
                    if (row == 0 && col == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write($" {board[row, col],-3} ");
                        Console.ResetColor();
                        Console.Write("|");
                    }
                    // Color the (x, y) cell with green foreground and cyan background
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

                // Display horizontal line
                Console.Write("   ");
                for (int col = 0; col < x; col++)
                {
                    Console.Write("------");
                }
                Console.WriteLine();

                // Reset the console colors after each row
                Console.ResetColor();
            }
        }

<<<<<<< Updated upstream
        public void PlayGame()
=======

        public void Move(Player currentPlayer)
>>>>>>> Stashed changes
        {
            // Create the board
            CreateBoard();

            // Display the initial board
            DisplayBoard(BoardMatrix);

            // Game loop
            while (!IsGameOver())
            {
                // Prompt the current player for a move
                Console.WriteLine($"Player {currentPlayer}'s turn");
                Console.Write("Enter the row and column to move (e.g., '2 3'): ");
                string input = Console.ReadLine();

                // Parse the input
                string[] inputParts = input.Split(' ');
                if (inputParts.Length != 2 || !int.TryParse(inputParts[0], out int row) || !int.TryParse(inputParts[1], out int col))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                // Validate the input
                if (row < 1 || row > y || col < 1 || col > x)
                {
                    Console.WriteLine("Invalid coordinates. Please try again.");
                    continue;
                }

                // Adjust the row and column to zero-based indices
                row--;
                col--;

                // Check if the selected cell is already occupied
                if (BoardMatrix[row, col] != "   ")
                {
                    Console.WriteLine("Selected cell is already occupied. Please try again.");
                    continue;
                }

                // Update the board with the player's move
                BoardMatrix[row, col] = currentPlayer == 1 ? " X " : " O ";

                // Switch to the next player
                currentPlayer = currentPlayer == 1 ? 2 : 1;

                // Display the updated board
                DisplayBoard(BoardMatrix);
            }

            // Game over, display the result or perform other actions
            Console.WriteLine("Game over!");
        }

        public bool IsGameOver()
        {
            // Add your game termination conditions here
            // Return true if the game should end, otherwise false
            return false;
        }
>>>>>>> Stashed changes
    }
}