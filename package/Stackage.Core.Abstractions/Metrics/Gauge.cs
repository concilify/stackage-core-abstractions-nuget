using System.Collections.Generic;

namespace Stackage.Core.Abstractions.Metrics
{
   public class Gauge : IMetric
   {
      public string Name { get; set; }

      public IDictionary<string, object> Dimensions { get; } = new Dictionary<string, object>();

      public double Value { get; set; }
   }
}
