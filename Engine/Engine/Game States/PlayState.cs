using System;

namespace Engine
{
	class PlayState : GameState
	{
		Player player = new Player((char)1, new Point(0, 0), new Color(ConsoleColor.Yellow));

		public override void onEnter()
		{
			player.draw();
		}

		public override void onExit()
		{
		}

		public override void update()
		{
		}

		public override void input(ConsoleKeyInfo key)
		{
			switch (key.Key)
			{
				case ConsoleKey.Escape:
					Game.instance().getStateMachine().push(new IntroState());
					break;
				case ConsoleKey.UpArrow:
					player.move(0, -1);
					break;
				case ConsoleKey.DownArrow:
					player.move(0, 1);
					break;
				case ConsoleKey.RightArrow:
					player.move(1, 0);
					break;
				case ConsoleKey.LeftArrow:
					player.move(-1, 0);
					break;
				default:
					break;
			}
		}
	}
}
