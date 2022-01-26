using Chapter3Sample4App.Logger;
using MyFrameworkWithCastle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3Sample4App
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
