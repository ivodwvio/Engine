using System;

namespace Engine
{
	class GameState
	{
		public virtual void onEnter() { }
		public virtual void onExit() { }

		public virtual void update() { }
		public virtual void input(ConsoleKeyInfo key) { }
	}
}
