using System.Threading;
using System.Threading.Tasks;

namespace Stackage.Core.Abstractions.StartupTasks
{
   public interface IStartupTasksExecutor
   {
      bool AllCompleteAndSuccessful { get; }

      Task<bool> AllCompleteAndSuccessfulAsync(CancellationToken cancellationToken);

      Task ExecuteAsync(CancellationToken cancellationToken);
   }
}
