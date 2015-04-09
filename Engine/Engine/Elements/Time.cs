using System;

namespace Engine
{
	class Time
	{
		public int hour, minute, second, millisecond;

		public Time(int hour = 0, int minute = 0, int second = 0,
			int millisecond = 0)
		{
			set(hour, minute, second, millisecond);
		}

		public Time(Time time)
		{
			set(time);
		}

		public Time(long milliseconds)
		{
			set(milliseconds);
		}

		public void set(Time time)
		{
			set(time.hour, time.minute, time.second, time.millisecond);
		}

		public void set(int hour, int minute, int second,
			int millisecond)
		{
			this.hour = hour;
			this.minute = minute;
			this.second = second;
			this.millisecond = millisecond;
		}

		public void set(long milliseconds)
		{
			millisecond = (int)milliseconds % 1000;
			second = (int)milliseconds / 1000 % 60;
			minute = (int)milliseconds / 1000 / 60 % 60;
			hour = (int)milliseconds / 1000 / 60 / 60 % 24;
		}

		public long getMilliseconds()
		{
			long result = 0;

			result = hour * 60 * 60 * 1000;
			result += minute * 60 * 1000;
			result += second * 1000;
			result += millisecond;

			return result;
		}

		public void recordCurrentTime()
		{
			hour = DateTime.Now.Hour;
			minute = DateTime.Now.Minute;
			second = DateTime.Now.Second;
			millisecond = DateTime.Now.Millisecond;
		}

		public override string ToString()
		{
			return string.Format("{0}:{1}:{2}:{3}",
				hour, minute, second, millisecond);
		}
	}
}
