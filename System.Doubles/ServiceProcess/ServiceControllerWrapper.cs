namespace System.ServiceProcess
{
    internal sealed class ServiceControllerWrapper : IServiceController
    {
        private readonly ServiceController serviceController;

        public ServiceControllerWrapper(ServiceController serviceController)
        {
            this.serviceController = serviceController;
        }

        public string ServiceName => serviceController.ServiceName;

        public string DisplayName => serviceController.DisplayName;

        public ServiceControllerStatus Status => serviceController.Status;

        public void Start()
        {
            serviceController.Start();
        }

        public void Stop()
        {
            serviceController.Stop();
        }

        public void Refresh()
        {
            serviceController.Refresh();
        }

        public void Dispose()
        {
            serviceController.Dispose();
        }
    }
}