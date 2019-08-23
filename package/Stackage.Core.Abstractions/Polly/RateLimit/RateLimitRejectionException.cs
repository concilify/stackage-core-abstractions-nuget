using Polly;

namespace Stackage.Core.Abstractions.Polly.RateLimit
{
   public class RateLimitRejectionException : ExecutionRejectedException
   {
   }
}
