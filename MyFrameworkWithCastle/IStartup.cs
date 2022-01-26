using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFrameworkWithCastle
{
    public interface IStartup
    {
        string LeadText { get; }

        void RegisterServices(IWindsorContainer windsorContainer);
    }
}
