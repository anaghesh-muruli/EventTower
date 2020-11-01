using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MessageBus.Utils
{
    public class ReflectionUtil : IReflectionUtil
    {
        public IEnumerable<Assembly> GetAssemblies()
        {
             var assemblies = System.Reflection.Assembly.GetEntryAssembly().GetReferencedAssemblies()
                    .Select(a => Assembly.Load(a))
                    .Append(Assembly.GetEntryAssembly());
                    
            return assemblies;
        }

        public IEnumerable<Type> GetTypes(IEnumerable<Assembly> assemblies)
        {
            return assemblies.SelectMany(a => a.GetTypes());
        }
    }
}