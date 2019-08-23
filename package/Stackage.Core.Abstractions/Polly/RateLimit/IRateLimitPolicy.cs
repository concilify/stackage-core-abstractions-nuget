using Polly;

namespace Stackage.Core.Abstractions.Polly.RateLimit
{
   public interface IRateLimitPolicy : IsPolicy
   {
   }

   public interface IRateLimitPolicy<TResult> : IRateLimitPolicy, IsPolicy
   {
   }
}
