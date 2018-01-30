namespace System.ServiceProcess
{
    public interface IServiceControllerFactory
    {
        IServiceController Create(string serviceName);

        IServiceController[] GetServices();
    }
}