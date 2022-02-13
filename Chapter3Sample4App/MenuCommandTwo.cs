using Chapter3Sample4App.Logger;
using MyFrameworkWithCastle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3Sample4App
{
    public class MenuCommandTwo : IMenuCommand
    {
        private readonly ILogger _logger;
        private readonly ISomeService _someService;
		public MenuCommandTwo(ILogger logger, ISomeService someService)
		{
			_logger = logger;
			_someService = someService;
		}

		public string OptionText => "Naciśnij klawisz 'W', żeby zobaczyć efekt";

        public char KeyCode => 'w';

        public void Execute()
        {
            Console.WriteLine("Naciśnąłeś klawisz 'W'");
            
            _logger.SomeText = "Ala ma kota";

            Console.WriteLine($"MenuCommandTwo->Logger->SomeText = {_logger.SomeText}");

            _someService.Foo();
        }
    }
}
