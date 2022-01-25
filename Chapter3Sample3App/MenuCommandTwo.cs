using System;
using System.Collections.Generic;
using System.Text;
using Chapter3Sample3App.Logger;
using MyExtendedFramework;

namespace Chapter3Sample3App
{
    public class MenuCommandTwo : IMenuCommand
    {
        //private readonly ILogger logger;
        //public MenuCommandTwo(ILogger logger)
        //{
        //    this.logger = logger;
        //}

        public string OptionText => "Naciśnij klawisz 'W', żeby zobaczyć efekt";

        public char KeyCode => 'w';

        public void Execute()
        {
            Console.WriteLine("Naciśnąłeś klawisz 'W'");
        }
    }
}
