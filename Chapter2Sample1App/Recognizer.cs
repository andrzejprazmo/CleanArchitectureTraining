using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Chapter2Sample1App
{
    public class Recognizer
    {
        public void WhoAmI(object someObject)
        {
            Type objectType = someObject.GetType();

            // 1. Nazwa typu, klasa bazowa, interfejsy
            string objectTypeName = objectType.FullName;
            Type objectBaseClassType = objectType.BaseType;
            Type[] objectInterfaces = objectType.GetInterfaces();
            IEnumerable<Attribute> objectAttributes = objectType.GetCustomAttributes();

            // 2. Konstruktory
            ConstructorInfo[] objectConstructors = objectType.GetConstructors();
            foreach (ConstructorInfo item in objectConstructors)
            {
                ParameterInfo[] constructorParameters = item.GetParameters();
                foreach (ParameterInfo parameterInfo in constructorParameters)
                {
                    Type parameterType = parameterInfo.ParameterType;
                    string parameterName = parameterInfo.Name;
                }
            }

            // 3. Właściwości (properties)
            PropertyInfo[] objectProperties = objectType.GetProperties();
            foreach (PropertyInfo item in objectProperties)
            {
                Type propertyType = item.PropertyType;
                string propertyName = item.Name;
                IEnumerable<Attribute> propertyAttributes = item.GetCustomAttributes();
                foreach (Attribute attribute in propertyAttributes)
                {
                    Type attributeType = attribute.GetType();
                }
            }

            // 4. Metody
            MethodInfo[] objectMethods = objectType.GetMethods();
            foreach (MethodInfo method in objectMethods)
            {
                ParameterInfo[] methodParameters = method.GetParameters();
                foreach (ParameterInfo parameterInfo in methodParameters)
                {
                    Type parameterType = parameterInfo.ParameterType;
                    string parameterName = parameterInfo.Name;
                }
            }
        }
    }
}
