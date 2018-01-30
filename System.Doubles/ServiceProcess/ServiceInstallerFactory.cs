namespace System.ServiceProcess
{
    public sealed class ServiceInstallerFactory : IServiceInstallerFactory
    {
        public IServiceInstaller Create()
        {
            return new ServiceInstallerWrapper(new ServiceInstaller());
        }
    }
}