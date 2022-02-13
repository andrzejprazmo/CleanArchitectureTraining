using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Chapter3Sample3App.Logger
{
	public class FileLogger : ILogger
	{
		public void LogError(Exception e)
		{
			using (var file = File.CreateText("log.txt"))
			{
				file.Write(e.Message);
			}
		}
	}
}
