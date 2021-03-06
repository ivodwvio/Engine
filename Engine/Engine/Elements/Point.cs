﻿using System;

namespace Engine
{
	class Point
	{
		public int x, y;

		public Point(int x = 0, int y = 0)
		{
			set(x, y);
		}

		public Point(Point point)
		{
			set(point);
		}

		public void set(Point point)
		{
			set(point.x, point.y);
		}

		public void set(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public bool gotoPoint()
		{
			if (isValidPosition())
			{
				Console.SetCursorPosition(x, y);
				return true;
			}

			return false;
		}

		public void getCurrentPoint()
		{
			this.x = Console.CursorLeft;
			this.y = Console.CursorTop;
		}

		public bool isValidPosition()
		{
			if (x < 0 || x >= Console.WindowWidth ||
				y < 0 || y >= Console.WindowHeight ||
				x == Console.WindowWidth - 1 &&
				y == Console.WindowHeight - 1)
			{
				return false;
			}

			return true;
		}
	}
}
