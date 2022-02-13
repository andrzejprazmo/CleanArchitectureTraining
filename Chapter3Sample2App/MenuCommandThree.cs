using MyFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3Sample2App
{
	public class MenuCommandThree : IMenuCommand
	{
		public string OptionText => "Naciśnij klawisz E";

		public char KeyCode => 'e';

		public void Execute()
		{
			Console.WriteLine("Naciśnąłeś klawisz 'E'");
		}
	}
}
