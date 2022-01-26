using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Chapter3Sample4App.Logger;
using MyFrameworkWithCastle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3Sample4App
{
    public class Startup : IStartup
    {
        public string LeadText => "Witamy w naszej aplikacji";

        public void RegisterServices(IWindsorContainer windsorContainer)
        {
            windsorContainer.Register(Component.For<IMenuCommand>().ImplementedBy<MenuCommandOne>().LifestyleTransient());
            windsorContainer.Register(Component.For<IMenuCommand>().ImplementedBy<MenuCommandTwo>().LifestyleTransient());
            windsorContainer.Register(Component.For<ILogger>().ImplementedBy<ConsoleLogger>().LifestyleTransient());
        }
    }
}
