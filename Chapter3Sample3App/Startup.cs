using System;
using System.Collections.Generic;
using System.Text;
using Chapter3Sample3App.Logger;
using MyExtendedFramework;

namespace Chapter3Sample3App
{
    public class Startup : IStartup
    {
        public string LeadText => "Witamy w naszej aplikacji";

		public void RegisterServices(Dictionary<Type, object> servicesDictionary)
		{
			servicesDictionary.Add(typeof(ILogger), new ConsoleLogger());
		}
	}
}
