namespace Stackage.Core.Abstractions.Metrics
{
   public interface ITimerFactory
   {
      ITimer CreateAndStart();
   }
}
