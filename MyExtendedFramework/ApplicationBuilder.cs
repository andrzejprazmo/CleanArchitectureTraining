using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace MyExtendedFramework
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

                Dictionary<Type, object> servicesDictionary = new Dictionary<Type, object>();
                
                startupClass.RegisterServices(servicesDictionary);

                Type[] menuCommandTypes = assemblyTypes.Where(t => !t.IsInterface && !t.IsAbstract && typeof(IMenuCommand).IsAssignableFrom(t)).ToArray();
                List<IMenuCommand> menuItems = new List<IMenuCommand>();
                foreach (var menuCommandType in menuCommandTypes)
                {
                    ConstructorInfo[] constructors = menuCommandType.GetConstructors();
                    List<object> constructorArgs = new List<object>();
					foreach (var constructorArgType in constructors[0].GetParameters())
					{
                        object argInstance = servicesDictionary[constructorArgType.ParameterType];
                        constructorArgs.Add(argInstance);
					}
                    IMenuCommand menuCommand = Activator.CreateInstance(menuCommandType, constructorArgs.ToArray()) as IMenuCommand;

                    menuItems.Add(menuCommand);
                }

                Console.WriteLine(startupClass.LeadText);
                foreach (var menuItem in menuItems)
                {
                    Console.WriteLine(menuItem.OptionText);
                }
                Console.WriteLine("Naciśnij klawisz 'Esc', żeby zakończyć.");

                while (true)
                {
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
