using System;

namespace Engine
{
	class Window
	{
		private string title;
		private Shape shape;
		private Color color;

		public Window(string title, Shape shape, Color color)
		{
			this.title = title;
			this.shape = shape;
			this.color = color;
		}

		public void onEnter()
		{
			Console.Title = title;
			Console.SetWindowSize(shape.width, shape.height);
			Console.SetBufferSize(shape.width, shape.height);
			Console.CursorVisible = false;
			clean();
		}

		public void onExit()
		{
			Console.ResetColor();
			Console.Clear();
			Console.SetWindowSize(80, 20);
			Console.SetBufferSize(80, 300);
			Console.CursorVisible = true;
			Console.Title = "";
		}

		public void resetColor()
		{
			color.apply();
		}

		public void clean()
		{
			resetColor();
			Console.Clear();
		}

		public Color getColor()
		{
			return color;
		}
	}
}
