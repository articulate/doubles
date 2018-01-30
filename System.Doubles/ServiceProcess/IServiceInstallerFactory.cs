namespace System.ServiceProcess
{
    public interface IServiceInstallerFactory
    {
        IServiceInstaller Create();
    }
}