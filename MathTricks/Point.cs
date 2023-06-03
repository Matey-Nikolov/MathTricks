using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTricks
{
    public class Point
    {
		private int x_PlayerMove;
		private int y_PlayerMOve;

		public int Y_PlayerMOve
        {
			get { return y_PlayerMOve; }
			set { y_PlayerMOve = value; }
		}

		public int X_PlayerMove
        {
			get { return x_PlayerMove; }
			set { x_PlayerMove = value; }
		}

		public Point(int x, int y)
		{
			X_PlayerMove = x;
			Y_PlayerMOve = y;
		}
	}
}
