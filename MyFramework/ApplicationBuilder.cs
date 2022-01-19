using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace MyFramework
{
    public class ApplicationBuilder
    {
        public void Run()
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            Type[] assemblyTypes = assemblies.SelectMany(a=>a.GetTypes()).ToArray();

            Type startupClassType = assemblyTypes.Where(t => !t.IsInterface && !t.IsAbstract && typeof(IStartup).IsAssignableFrom(t)).FirstOrDefault();
            if (startupClassType != null)
            {
                IStartup startupClass = Activator.CreateInstance(startupClassType) as IStartup;

                Type[] menuCommandTypes = assemblyTypes.Where(t => !t.IsInterface && !t.IsAbstract && typeof(IMenuCommand).IsAssignableFrom(t)).ToArray();
                List<IMenuCommand> menuItems = new List<IMenuCommand>();
                foreach (var menuCommandType in menuCommandTypes)
                {
                    IMenuCommand menuCommand = Activator.CreateInstance(menuCommandType) as IMenuCommand;
                    menuItems.Add(menuCommand);
                }
                while (true)
                {
                    Console.WriteLine(startupClass.LeadText);
                    foreach (var menuItem in menuItems)
                    {
                        Console.WriteLine(menuItem.OptionText);
                    }
                    var keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                    IMenuCommand selectedCommand = menuItems.FirstOrDefault(m => m.KeyCode == keyInfo.KeyChar);
                    if (selectedCommand != null)
                    {
                        Console.WriteLine();
                        selectedCommand.Execute();
                    }
                }
            }


        }
    }
}
