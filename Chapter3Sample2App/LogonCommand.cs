using MyFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3Sample2App
{
	public class LogonCommand : IMenuCommand
	{
        private readonly UserContext _userContext;
		public LogonCommand(UserContext userContext)
		{
			_userContext = userContext;
		}

		public string OptionText => "Naciśnij klawisz 'L', żeby się zalogować";

        public char KeyCode => 'l';

        public void Execute()
        {
            Console.WriteLine("Jesteś zalogowany");
            
            _userContext.IsAuthenticated = true;
        }
    }
}
