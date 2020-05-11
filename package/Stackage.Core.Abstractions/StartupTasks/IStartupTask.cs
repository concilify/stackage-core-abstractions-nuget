using System.Threading;
using System.Threading.Tasks;

namespace Stackage.Core.Abstractions.StartupTasks
{
   public interface IStartupTask
   {
      Task ExecuteAsync(CancellationToken cancellationToken);
   }
}
