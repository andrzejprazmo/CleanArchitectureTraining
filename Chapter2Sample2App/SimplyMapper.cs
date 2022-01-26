using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Chapter2Sample2App
{
    public class SimplyMapper
    {
        public void Map(object source, object target)
        {
            Type sourceType = source.GetType();
            PropertyInfo[] sourceProperties = sourceType.GetProperties();

            Type targetType = target.GetType();
            PropertyInfo[] targetProperties = targetType.GetProperties();
            foreach (PropertyInfo sourceProperty in sourceProperties)
            {
                string sourcePropertyName = sourceProperty.Name;
                PropertyInfo targetProperty = targetProperties.Where(p => p.Name == sourcePropertyName).SingleOrDefault();
                if (targetProperty != null)
                {
                    object sourceValue = sourceProperty.GetValue(source);
                    targetProperty.SetValue(target, sourceValue);
                }
            }
        }

        public TTarget Map<TTarget>(object source)
        {
            TTarget target = Activator.CreateInstance<TTarget>();
            Map(source, target);
            return target;
        }
    }
}
