using System;

namespace Engine
{
	class StateMachine
	{
		private GameState state;

		public void push(GameState state)
		{
			if (this.state == null)
			{
				this.state = state;
			}
			else
			{
				this.state.onExit();
				Game.instance().getWindow().clean();
				this.state = state;
			}

			this.state.onEnter();
		}

		public void pop()
		{
			if (state != null)
			{
				state.onExit();
				Game.instance().getWindow().clean();
				state = null;
			}
		}

		public void update()
		{
			if (state != null)
				state.update();
		}

		public void input(ConsoleKeyInfo key)
		{
			if (state != null)
				state.input(key);
		}
	}
}
