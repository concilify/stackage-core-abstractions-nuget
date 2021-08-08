using System.Threading;
using System.Threading.Tasks;

namespace Stackage.Core.Abstractions.RateLimiting
{
   public interface IRateLimiter
   {
      Task WaitAsync(CancellationToken cancellationToken);
   }
}
