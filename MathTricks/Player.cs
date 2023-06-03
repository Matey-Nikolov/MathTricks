using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTricks
{
    public class Player : Point
    {
        private string name;
        private int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Player(string name, int x, int y)
        : base(x, y)
        {
            Name = name;
            Score = 0;
        }
    }
}
