using System;

namespace Engine
{
	class PlayState : GameState
	{
		Element player = new Element((char)1, new Point(0, 0), new Color(ConsoleColor.Yellow));

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
			if (key.Key == ConsoleKey.Escape)
			{
				Game.instance().getStateMachine().push(new IntroState());
			}
			else if (key.Key == ConsoleKey.RightArrow)
			{
				player.move(1, 0);
			}
			else if (key.Key == ConsoleKey.LeftArrow)
			{
				player.move(-1, 0);
			}
			else if (key.Key == ConsoleKey.UpArrow)
			{
				player.move(0, -1);
			}
			else if (key.Key == ConsoleKey.DownArrow)
			{
				player.move(0, 1);
			}
		}
	}
}
