using System;
using System.Collections.Generic;
using System.Text;
using MyFramework;

namespace ConsoleApp1
{
    public class MenuCommandTwo : IMenuCommand
    {
        public string OptionText => "Naciśnij klawisz 'W', żeby zobaczyć efekt";

        public char KeyCode => 'w';

        public void Execute()
        {
            Console.WriteLine("Naciśnąłeś klawisz 'W'");
        }
    }
}
