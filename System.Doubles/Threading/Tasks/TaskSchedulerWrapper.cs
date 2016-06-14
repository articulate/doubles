namespace System.Threading.Tasks
{
    public sealed class TaskSchedulerWrapper : ITaskScheduler
    {
        public event EventHandler<UnobservedTaskExceptionEventArgs> UnobservedTaskException
        {
            add
            {
                TaskScheduler.UnobservedTaskException += value;
            }
            remove
            {
                TaskScheduler.UnobservedTaskException -= value;
            }
        }
    }
}