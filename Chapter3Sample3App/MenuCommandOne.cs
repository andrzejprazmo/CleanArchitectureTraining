using System;
using System.Collections.Generic;
using System.Text;
using Chapter3Sample3App.Logger;
using MyExtendedFramework;

namespace Chapter3Sample3App
{
	public class MenuCommandOne : IMenuCommand
	{
		private readonly ILogger _logger;
		private readonly UserContext _userContext;
		public MenuCommandOne(ILogger logger, UserContext userContext)
		{
			_logger = logger;
			_userContext = userContext;
		}

		public string OptionText => "Naciśnij klawisz 'Q', żeby zobaczyć efekt";

		public char KeyCode => 'q';

		public void Execute()
		{
			try
			{
				int x = 10;
				int y = 0;
				Console.WriteLine($"x/y = {x / y}");
			}
			catch (Exception e)
			{
				_logger.LogError(e);
			}

			if (_userContext.IsAuthenticated)
			{
				Console.WriteLine("Naciśnąłeś klawisz 'Q'");
			}
			Console.WriteLine("Zaloguj się");
		}
	}
}
