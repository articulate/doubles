using System.Linq;

namespace System.ServiceProcess
{
    public sealed class ServiceControllerFactory : IServiceControllerFactory
    {
        public IServiceController Create(string serviceName)
        {
            return new ServiceControllerWrapper(new ServiceController(serviceName));
        }

        public IServiceController[] GetServices()
        {
            return ServiceController.GetServices().Select(controller => new ServiceControllerWrapper(controller)).Cast<IServiceController>().ToArray();
        }
    }
}