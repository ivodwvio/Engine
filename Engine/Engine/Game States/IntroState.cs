using System;

namespace Engine
{
	class IntroState : GameState
	{
		string msg = "Press ENTER to start the game.";

		public override void onEnter()
		{
			Console.Write(msg);
		}

		public override void onExit()
		{
		}

		public override void update()
		{
		}

		public override void input(ConsoleKeyInfo key)
		{
			if (key.Key == ConsoleKey.Enter)
			{
				Game.instance().getStateMachine().push(new PlayState());
			}
			else if (key.Key == ConsoleKey.Escape)
			{
				Game.instance().exit();
			}
		}
	}
}
