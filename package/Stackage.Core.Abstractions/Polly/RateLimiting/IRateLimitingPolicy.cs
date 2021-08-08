using Polly;

namespace Stackage.Core.Abstractions.Polly.RateLimiting
{
   public interface IRateLimitingPolicy : IsPolicy
   {
   }

   public interface IRateLimitingPolicy<TResult> : IRateLimitingPolicy, IsPolicy
   {
   }
}
