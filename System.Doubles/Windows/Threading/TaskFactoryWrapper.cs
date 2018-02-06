using System.Threading;
using System.Threading.Tasks;

namespace System.Windows.Threading
{
    public sealed class TaskFactoryWrapper : ITaskFactory
    {
        public Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions taskCreationOptions, TaskScheduler taskScheduler)
        {
            return Task.Factory.StartNew(action, cancellationToken, taskCreationOptions, taskScheduler);
        }
    }
}