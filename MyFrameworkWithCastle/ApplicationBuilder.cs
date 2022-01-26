using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace MyFrameworkWithCastle
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

                IWindsorContainer windsorContainer = new WindsorContainer();

                startupClass.RegisterServices(windsorContainer);

                var menuItems = windsorContainer.ResolveAll<IMenuCommand>();

                while (true)
                {
                    Console.WriteLine(startupClass.LeadText);
                    foreach (var menuItem in menuItems)
                    {
                        Console.WriteLine(menuItem.OptionText);
                    }
                    Console.WriteLine("Naciśnij klawisz 'Esc', żeby zakończyć.");
                    
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
