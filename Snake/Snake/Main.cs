using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Point p1 = new Point (1, 2, '*');
			p1.Draw ();

			Point p2 = new Point (4, 5, '#');
			p2.Draw ();

			HorizontalLine hline = new HorizontalLine (5, 10, 8, '+');
			hline.Draw ();

			VerticalLine vline = new VerticalLine (9, 14, 11, '+');
			vline.Draw ();


			HorizontalLine hsline = new HorizontalLine (5, 10, 15, '+');
			hsline.Draw ();

			VerticalLine vsline = new VerticalLine (9, 14, 4, '+');
			vsline.Draw ();

			Console.ReadLine ();
		}

	}

}
