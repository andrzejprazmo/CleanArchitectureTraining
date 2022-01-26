using System;
using System.Collections.Generic;
using System.Text;

namespace MyFrameworkWithCastle
{
    public interface IMenuCommand
    {
        string OptionText { get; }
        char KeyCode { get; }
        void Execute();
    }
}
