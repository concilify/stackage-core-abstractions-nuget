using Polly;

namespace Stackage.Core.Abstractions.Polly.Metrics
{
   public interface IMetricsPolicy : IsPolicy
   {
   }

   public interface IMetricsPolicy<TResult> : IMetricsPolicy, IsPolicy
   {
   }
}
