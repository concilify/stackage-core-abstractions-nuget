namespace Stackage.Core.Abstractions.Metrics
{
   public interface ITimingBlockFactory
   {
      ITimingBlock Create(string name);
   }
}
