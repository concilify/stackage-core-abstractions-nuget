using System.Threading.Tasks;

namespace Stackage.Core.Abstractions.Metrics
{
   public interface IMetricSink
   {
      Task PushAsync(IMetric metric);
   }
}
