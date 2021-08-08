using System;

namespace Stackage.Core.Abstractions.RateLimiting
{
   public class RateLimitExceededException : Exception
   {
      public RateLimitExceededException(string message)
         : base(message)
      {
      }
   }
}
