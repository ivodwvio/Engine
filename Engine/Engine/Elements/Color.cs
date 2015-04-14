using System;

namespace Engine
{
	class Color
	{
		public ConsoleColor forecolor, backcolor;

		public Color(ConsoleColor forecolor = ConsoleColor.White,
			ConsoleColor backcolor = ConsoleColor.Black)
		{
			set(forecolor, backcolor);
		}

		public Color(Color color)
		{
			set(color);
		}

		public void set(ConsoleColor forecolor, ConsoleColor backcolor)
		{
			this.forecolor = forecolor;
			this.backcolor = backcolor;
		}

		public void set(Color color)
		{
			set(color.forecolor, color.backcolor);
		}

		public void apply()
		{
			Console.ForegroundColor = forecolor;
			Console.BackgroundColor = backcolor;
		}

		public void getCurrentColor()
		{
			this.forecolor = Console.ForegroundColor;
			this.backcolor = Console.BackgroundColor;
		}
	}
}
