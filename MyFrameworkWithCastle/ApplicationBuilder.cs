using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Lifestyle;

namespace MyFrameworkWithCastle
{
    public class ApplicationBuilder
    {
        public void Run<TStartup>() where TStartup : IStartup
        {
            IWindsorContainer windsorContainer = new WindsorContainer();

            //windsorContainer.Register()

            windsorContainer.Register(Classes.FromAssemblyContaining(typeof(TStartup)).BasedOn<IStartup>().WithServiceDefaultInterfaces().LifestyleTransient());

            windsorContainer.Register(Classes.FromAssemblyContaining(typeof(TStartup)).BasedOn<IMenuCommand>().WithServiceDefaultInterfaces().LifestyleTransient());

            IStartup startupClass = windsorContainer.Resolve<IStartup>();

            if (startupClass != null)
            {
                using (windsorContainer.BeginScope())
				{
                    startupClass.RegisterServices(windsorContainer);

                    var menuItems = windsorContainer.ResolveAll<IMenuCommand>();

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
}
