using System.Threading;
using System.Threading.Tasks;

namespace System.Windows.Threading
{
    public interface ITaskFactory
    {
        Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions taskCreationOptions, TaskScheduler taskScheduler);
    }
}