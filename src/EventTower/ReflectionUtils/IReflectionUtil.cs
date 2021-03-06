using System;
using System.Collections.Generic;
using System.Reflection;

namespace EventTower.Utils
{
    public interface IReflectionUtil
    {
        IEnumerable<Assembly> GetAssemblies();
        IEnumerable<Type> GetTypes(IEnumerable<Assembly> assemblies);

    }
}