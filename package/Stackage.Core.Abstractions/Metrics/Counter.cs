using System;
using System.Collections.Generic;

namespace Stackage.Core.Abstractions.Metrics
{
   public class Counter : IMetric
   {
      public Counter(string name)
      {
         if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(name));

         Name = name;
      }

      public string Name { get; }

      public IDictionary<string, object> Dimensions { get; set; } = new Dictionary<string, object>();
   }
}
