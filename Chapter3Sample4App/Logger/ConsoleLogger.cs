using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3Sample4App.Logger
{
	public class ConsoleLogger : ILogger
	{
		public string SomeText { get; set; }

		public void LogError(Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
}
