namespace Engine
{
	class Timer
	{
		public Time startTime = new Time();
		public Time stopTime = new Time();

		public void start()
		{
			startTime.recordCurrentTime();
		}

		public void stop()
		{
			stopTime.recordCurrentTime();
		}

		public long getMilliseconds()
		{
			return stopTime.getMilliseconds() - startTime.getMilliseconds();
		}

		public Time getTime()
		{
			return new Time(getMilliseconds());
		}

		public override string ToString()
		{
			return getTime().ToString();
		}
	}
}
