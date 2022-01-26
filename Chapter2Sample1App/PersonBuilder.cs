using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Chapter2Sample1App
{
    public class PersonBuilder
    {
        public void Build()
        {
            Type personType = typeof(Person);

            Person person = Activator.CreateInstance(personType) as Person;

            PropertyInfo[] personProperties = personType.GetProperties();
            foreach (PropertyInfo personProperty in personProperties)
            {
                if (personProperty.Name == "FirstName")
                {
                    personProperty.SetValue(person, "Jan");
                }
                if (personProperty.Name == "LastName")
                {
                    personProperty.SetValue(person, "Kowalski");
                }
            }
            MethodInfo[] personMethods = personType.GetMethods();
            MethodInfo getFullNameMethodInfo = personMethods.Where(m => m.Name == "GetFullName").FirstOrDefault();
            var result = getFullNameMethodInfo.Invoke(person, new object[] { "R" });
            Console.WriteLine(result);
        }
    }
}
