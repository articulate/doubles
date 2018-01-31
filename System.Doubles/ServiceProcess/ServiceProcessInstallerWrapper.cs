namespace System.ServiceProcess
{
    internal sealed class ServiceProcessInstallerWrapper : IServiceProcessInstaller
    {
        public ServiceAccount Account
        {
            get => serviceProcessInstaller.Account;
            set => serviceProcessInstaller.Account = value;
        }

        public string Username
        {
            get => serviceProcessInstaller.Username;
            set => serviceProcessInstaller.Username = value;
        }

        public string Password
        {
            get => serviceProcessInstaller.Password;
            set => serviceProcessInstaller.Password = value;
        }

        internal ServiceProcessInstaller Wrapped => serviceProcessInstaller;

        private readonly ServiceProcessInstaller serviceProcessInstaller;

        public ServiceProcessInstallerWrapper(ServiceProcessInstaller serviceProcessInstaller)
        {
            this.serviceProcessInstaller = serviceProcessInstaller;
        }

        public void Dispose()
        {
            serviceProcessInstaller.Dispose();
        }
    }
}