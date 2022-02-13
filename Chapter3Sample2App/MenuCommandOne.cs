using System;
using System.Collections.Generic;
using System.Text;
using MyFramework;

namespace Chapter3Sample2App
{
    public class MenuCommandOne : IMenuCommand
    {
        private readonly UserContext _userContext;
        public MenuCommandOne(UserContext userContext)
        {
            _userContext = userContext;
        }

        public string OptionText => "Naciśnij klawisz 'Q', żeby zobaczyć efekt";

        public char KeyCode => 'q';

        public void Execute()
        {
			if (_userContext.IsAuthenticated)
			{
                Console.WriteLine("Naciśnąłeś klawisz 'Q'");
            }
            Console.WriteLine("Zaloguj się");
        }
    }
}
