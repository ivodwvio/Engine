using System;

namespace Engine
{
	class Element
	{
		public char sign;
		public Point pos;
		public Color color;

		public Element(char sign, Point pos, Color color)
		{
			this.sign = sign;
			this.pos = pos;
			this.color = color;
		}

		public virtual void draw()
		{
			if (pos.gotoPoint())
			{
				color.apply();
				Console.Write(sign);
				Game.instance().getWindow().resetColor();
			}
		}

		public virtual void erase()
		{
			if (pos.gotoPoint())
			{
				Console.Write(' ');
			}
		}

		public virtual void move(int x, int y)
		{
			erase();
			pos.x += x;
			pos.y += y;
			draw();
		}
	}
}
