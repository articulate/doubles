namespace System.ServiceProcess
{
    public interface IServiceProcessInstallerFactory
    {
        IServiceProcessInstaller Create();
    }
}