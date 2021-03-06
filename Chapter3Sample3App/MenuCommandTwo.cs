using System;
using System.Collections.Generic;
using System.Text;
using Chapter3Sample3App.Logger;
using MyExtendedFramework;

namespace Chapter3Sample3App
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
