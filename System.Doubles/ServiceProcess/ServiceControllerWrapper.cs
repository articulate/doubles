namespace System.ServiceProcess
{
    internal sealed class ServiceControllerWrapper : IServiceController
    {
        private readonly ServiceController serviceController;

        public ServiceControllerWrapper(ServiceController serviceController)
        {
            this.serviceController = serviceController;
        }

        public void Start()
        {
            serviceController.Start();
        }

        public void Stop()
        {
            serviceController.Stop();
        }

        public void Dispose()
        {
            serviceController.Dispose();
        }
    }
}