using System;
using System.Collections.Generic;
using System.Text;
using Chapter3Sample3App.Logger;
using MyExtendedFramework;

namespace Chapter3Sample3App
{
    public class MenuCommandOne : IMenuCommand
    {
        private readonly ILogger logger;
		public MenuCommandOne(ILogger logger)
		{
			this.logger = logger;
		}

        public string OptionText => "Naciśnij klawisz 'Q', żeby zobaczyć efekt";

        public char KeyCode => 'q';

        public void Execute()
        {
            Console.WriteLine("Naciśnąłeś klawisz 'Q'");
        }
    }
}
