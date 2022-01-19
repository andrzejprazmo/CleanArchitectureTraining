using System;
using System.Collections.Generic;
using System.Text;
using MyFramework;

namespace ConsoleApp1
{
    public class MenuCommandOne : IMenuCommand
    {
        public string OptionText => "Naciśnij klawisz 'Q', żeby zobaczyć efekt";

        public char KeyCode => 'q';

        public void Execute()
        {
            Console.WriteLine("Naciśnąłeś klawisz 'Q'");
        }
    }
}
