using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Chapter2Sample2App
{
    public class ClassPresenter
    {
        public void DisplayProperties(object someObject)
        {
            Type objectType = someObject.GetType();
            PropertyInfo[] objectProperties = objectType.GetProperties();
            foreach (PropertyInfo propertyInfo in objectProperties)
            {
                string propertyName = propertyInfo.Name;
                FamiliarNameAttribute attribute = propertyInfo.GetCustomAttribute<FamiliarNameAttribute>();
                if (attribute != null)
                {
                    propertyName = attribute.Name;
                }
                object propertyValue = propertyInfo.GetValue(someObject);
                Console.WriteLine($"{propertyName} = {propertyValue}");
            }
        }
    }
}
