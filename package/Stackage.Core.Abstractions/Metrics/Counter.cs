using System.Collections.Generic;

namespace Stackage.Core.Abstractions.Metrics
{
   public class Counter : IMetric
   {
      public string Name { get; set; }

      public IDictionary<string, object> Dimensions { get; set; } = new Dictionary<string, object>();
   }
}
