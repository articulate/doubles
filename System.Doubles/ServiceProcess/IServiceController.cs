namespace System.ServiceProcess
{
    public interface IServiceController : IDisposable
    {
        void Start();

        void Stop();
    }
}