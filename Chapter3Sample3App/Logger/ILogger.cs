using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3Sample3App.Logger
{
	public interface ILogger
	{
		void LogError(Exception e);
	}
}
