using System;
using System.Collections.Generic;
using System.Text;

namespace MyExtendedFramework
{
    public interface IStartup
    {
        string LeadText { get; }

        void RegisterServices(Dictionary<Type, object> servicesDictionary);
    }
}
