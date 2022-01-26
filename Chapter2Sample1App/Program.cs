using System;
using System.Collections.Generic;
using System.Reflection;

namespace Chapter2Sample1App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recognizer recognizer = new Recognizer();
            //recognizer.WhoAmI(new Person());

            PersonBuilder builder = new PersonBuilder();
            builder.Build();
        }
    }
}
