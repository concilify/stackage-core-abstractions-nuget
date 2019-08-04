using Polly;

namespace Stackage.Core.Abstractions.Polly.Timing
{
   public interface ITimingPolicy : IsPolicy
   {
   }

   public interface ITimingPolicy<TResult> : ITimingPolicy, IsPolicy
   {
   }
}
