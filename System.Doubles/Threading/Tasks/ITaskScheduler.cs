namespace System.Threading.Tasks
{
    public interface ITaskScheduler
    {
        event EventHandler<UnobservedTaskExceptionEventArgs> UnobservedTaskException;
    }
}