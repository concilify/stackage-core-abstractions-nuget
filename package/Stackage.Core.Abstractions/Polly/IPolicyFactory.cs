using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Polly;
using Stackage.Core.Abstractions.Metrics;
using Stackage.Core.Abstractions.Polly.RateLimit;

namespace Stackage.Core.Abstractions.Polly
{
   public interface IPolicyFactory
   {
      IAsyncPolicy CreateAsyncRateLimitPolicy(
         IRateLimiter rateLimiter,
         Func<Context, Exception, Task> onRejectionAsync = null);

      IAsyncPolicy<TResult> CreateAsyncRateLimitPolicy<TResult>(
         IRateLimiter rateLimiter,
         Func<Context, Exception, Task> onRejectionAsync = null);

      IAsyncPolicy CreateAsyncTimingPolicy(
         string name,
         IMetricSink metricSink,
         IDictionary<string, object> policyDimensions = null,
         Func<Context, Task> onSuccessAsync = null,
         Func<Context, Exception, Task> onExceptionAsync = null);

      IAsyncPolicy<TResult> CreateAsyncTimingPolicy<TResult>(
         string name,
         IMetricSink metricSink,
         IDictionary<string, object> policyDimensions = null,
         Func<Context, TResult, Task> onSuccessAsync = null,
         Func<Context, Exception, Task> onExceptionAsync = null);
   }
}
