namespace Engine
{
	class Shape
	{
		public int width, height;

		public Shape(int width = 0, int height = 0)
		{
			set(width, height);
		}

		public Shape(Shape shape)
		{
			set(shape);
		}

		public void set(int width, int height)
		{
			this.width = width;
			this.height = height;
		}

		public void set(Shape shape)
		{
			set(shape.width, shape.height);
		}
	}
}
