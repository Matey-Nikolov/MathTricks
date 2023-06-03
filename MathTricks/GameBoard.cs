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

                x = value;
            }
        }

        public GameBoard(uint x, uint y)
        {
            X = x;
            Y = y;
        }
    }
}