namespace Stackage.Core.Abstractions.Metrics
{
   public interface ITimer
   {
      long ElapsedMilliseconds { get; }

      void Stop();
   }
}
