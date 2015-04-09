namespace Engine
{
	class Player : Element
	{
		public Player(char sign, Point pos, Color color)
			: base(sign, pos, color)
		{
		}

		public override void move(int x, int y)
		{
			Point p = new Point(this.pos.x + x, this.pos.y + y);

			if (p.isValidPosition())
			{
				base.move(x, y);
			}
		}
	}
}
