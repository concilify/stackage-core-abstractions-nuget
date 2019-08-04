using System.Threading;
using System.Threading.Tasks;

namespace Stackage.Core.Abstractions.Polly.RateLimit
{
   public interface IRateLimiter
   {
      Task WaitAsync(CancellationToken cancellationToken);
   }
}