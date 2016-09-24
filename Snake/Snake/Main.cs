using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.SetWindowSize (1, 1);
			Console.SetBufferSize (80, 25);
			Console.SetWindowSize (80, 25);

			HorizontalLine hline = new HorizontalLine (0, 78, 0, '#');
			VerticalLine vline = new VerticalLine (1, 24, 0, '#');
			HorizontalLine hsline = new HorizontalLine (1, 78, 24, '#');
			VerticalLine vsline = new VerticalLine (1, 24, 78, '#');
			hline.Draw ();
			vline.Draw ();
			hsline.Draw ();
			vsline.Draw ();


			Point p = new Point (6, 13, '*');
			Snake snake = new Snake (p, 4, Direction.RIGHT);
			snake.Draw ();

			FoodCreator foodCreator = new FoodCreator (80, 25, '$');
			Point food = foodCreator.CreateFood ();
			food.Draw ();

			while (true) {

				if(snake.Eat(food))
				{
					food = foodCreator.CreateFood ();
					food.Draw ();
				}else
				{
					snake.Move ();
				}

				Thread.Sleep (100);

				if(Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey ();
					snake.HandleKey (key.Key);
				}
			}
		}		
	}

}
