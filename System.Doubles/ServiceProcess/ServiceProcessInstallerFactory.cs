namespace System.ServiceProcess
{
    public sealed class ServiceProcessInstallerFactory : IServiceProcessInstallerFactory
    {
        public IServiceProcessInstaller Create()
        {
            return new ServiceProcessInstallerWrapper(new ServiceProcessInstaller());
        }
    }
}