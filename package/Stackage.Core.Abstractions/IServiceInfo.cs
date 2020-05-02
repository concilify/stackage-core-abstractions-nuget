using System;

namespace Stackage.Core.Abstractions
{
   public interface IServiceInfo
   {
      string Service { get; }

      string Version { get; }

      string Host { get; }

      string BaseAddress { get; }
   }
}
