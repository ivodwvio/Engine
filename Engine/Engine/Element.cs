using System;

namespace Engine
{
	class Element
	{
		private char sign;
		private Point pos;
		private Color color;

		public Element(char sign, Point pos, Color color)
		{
			this.sign = sign;
			this.pos = pos;
			this.color = color;
		}

		public void draw()
		{
			if (pos.gotoPoint())
			{
				color.apply();
				Console.Write(sign);
				Game.instance().getWindow().resetColor();
			}
		}

		public void erase()
		{
			if (pos.gotoPoint())
			{
				Console.Write(' ');
			}
		}

		public void move(int x, int y)
		{
			erase();
			pos.x += x;
			pos.y += y;
			draw();
		}
	}
}
