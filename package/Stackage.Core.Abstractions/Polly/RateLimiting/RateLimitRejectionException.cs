using Polly;
using Stackage.Core.Abstractions.RateLimiting;

namespace Stackage.Core.Abstractions.Polly.RateLimiting
{
   public class RateLimitRejectionException : ExecutionRejectedException
   {
      public RateLimitRejectionException(string message, RateLimitExceededException innerException)
         : base(message, innerException)
      {

      }
   }
}
