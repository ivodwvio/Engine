using System;

namespace Engine
{
	class Game
	{
		private static Game game;

		private Game() { }

		public static Game instance()
		{
			if (game == null)
			{
				game = new Game();
			}

			return game;
		}

		Window window = new Window("Engine", new Shape(80, 30), new Color());
		StateMachine stateMachine = new StateMachine();

		public Window getWindow()
		{
			return window;
		}

		public StateMachine getStateMachine()
		{
			return stateMachine;
		}

		private void init()
		{
			window.onEnter();
			stateMachine.push(new IntroState());
		}

		private void clean()
		{
			stateMachine.pop();
			window.onExit();
		}

		public void run()
		{
			init();
			loop();
			clean();
		}

		bool running = true;

		private void loop()
		{
			ConsoleKeyInfo key = new ConsoleKeyInfo();

			while (running)
			{
				while (!Console.KeyAvailable)
				{
					stateMachine.update();
				}

				key = Console.ReadKey(true);
				stateMachine.input(key);
			}
		}

		public void exit()
		{
			running = false;
		}
	}
}
