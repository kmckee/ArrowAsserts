using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArrowAsserts
{
    public class ReferenceChecker
    {
        public bool DoesAReferenceB(string assemblyA, string assemblyB)
        {
            var a = Assembly.ReflectionOnlyLoad(assemblyA);
            var references = a.GetReferencedAssemblies();
            return references.Any(assemblyAReference => assemblyAReference.Name.StartsWith(assemblyB));
        }
    }
}
