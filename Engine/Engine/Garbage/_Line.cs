namespace Engine
{
	enum Direction
	{
		LEFT,
		RIGHT,
		UP,
		DOWN
	}

	class _Line
	{
		public Direction direction;
		public Point pos;
		public int lenght;
		public Element element;

		public _Line(Point pos, Direction direction, int length,
			Element element)
		{
			this.pos = pos;
			this.direction = direction;
			this.lenght = length;
			this.element = element;
		}

		public void draw()
		{
			if (direction == Direction.RIGHT)
			{
				element.pos = new Point(pos);
				element.draw();
				for (int x = 0; x < lenght; x++)
				{
					element.pos.x++;
					element.draw();
				}
			}
		}

		public void erase()
		{
		}

		public void move()
		{
		}
	}
}
