using System;
using System.Threading.Tasks;
using Polly;
using Stackage.Core.Abstractions.RateLimiting;

namespace Stackage.Core.Abstractions.Polly
{
   public interface IPolicyFactory
   {
      IAsyncPolicy CreateAsyncRateLimitingPolicy(
         IRateLimiter rateLimiter,
         Func<Context, Exception, Task>? onRejectionAsync = null);

      IAsyncPolicy<TResult> CreateAsyncRateLimitingPolicy<TResult>(
         IRateLimiter rateLimiter,
         Func<Context, Exception, Task>? onRejectionAsync = null);

      IAsyncPolicy CreateAsyncMetricsPolicy(
         string name,
         Func<Context, Task>? onSuccessAsync = null,
         Func<Context, Exception, Task>? onExceptionAsync = null);

      IAsyncPolicy<TResult> CreateAsyncMetricsPolicy<TResult>(
         string name,
         Func<Context, TResult, Task>? onSuccessAsync = null,
         Func<Context, Exception, Task>? onExceptionAsync = null);
   }
}
