using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3Sample3App.Logger
{
	public class ConsoleLogger : ILogger
	{
		public void LogError(Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
}
