using System;
using System.Reflection;

namespace Chapter2Sample3App
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();

            Assembly externalAssembly = typeof(This.Is.Some.External.Library.AssemblyMarker).Assembly;

            Type[] assemblyTypes = assembly.GetTypes();



        }
    }
}
