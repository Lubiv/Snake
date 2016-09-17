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

			List<int> numList = new List<int>();
			numList.Add (0);
			numList.Add (1);
			numList.Add (2);

			int x = numList [0];
			int y = numList [1];
			int z = numList [2];

			foreach (int i in numList) {
				Console.WriteLine(i);
			}

			numList.RemoveAt (1);

			List<Point> pList = new List<Point> ();
			pList.Add (p1);
			pList.Add (p2);







			List<char> chList = new List<Char> ();
			chList.Add ('$');
			chList.Add ('%');
			chList.Add ('&');
			chList.Add ('^');
			
			Point mp1 = new Point (1, 5, chList[0]);
			
			Point mp2 = new Point (3, 8, chList[1]);
			
			Point mp3 = new Point (2, 2, chList[2]);
			
			Point mp4 = new Point (2, 8, chList[3]);


			List<Point> mpList = new List<Point> ();
			mpList.Add (mp1);
			mpList.Add (mp2);
			mpList.Add (mp3);
			mpList.Add (mp4);

			foreach (Point i in mpList) {
				i.Draw ();
			}

			Console.ReadLine ();
		}

	}

}
