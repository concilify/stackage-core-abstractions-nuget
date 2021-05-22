using System;
using System.Collections.Generic;

namespace Stackage.Core.Abstractions
{
   public interface ITypeEnumerator
   {
      IEnumerable<Type> Types { get; }

      IEnumerable<(Type ImplementationType, (Type ServiceType, Type[] GenericArguments)[] Services)> GetGenericTypes(Type genericServiceType);
   }
}
