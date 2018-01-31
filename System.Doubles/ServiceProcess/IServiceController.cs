namespace System.ServiceProcess
{
    public interface IServiceController : IDisposable
    {
        string ServiceName
        {
            get;
        }

        ServiceControllerStatus Status
        {
            get;
        }

        string DisplayName
        {
            get;
        }

        void Start();

        void Stop();

        void Refresh();
    }
}