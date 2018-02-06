using System.Threading;
using System.Threading.Tasks;

namespace System.Windows.Threading
{
    internal interface ITaskFactory
    {
        Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions taskCreationOptions, TaskScheduler taskScheduler);
    }
}