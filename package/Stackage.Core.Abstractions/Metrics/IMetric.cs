using System.Collections.Generic;

namespace Stackage.Core.Abstractions.Metrics
{
   public interface IMetric
   {
      string Name { get; }

      IDictionary<string, object> Dimensions { get; }
   }
}
