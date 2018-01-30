using System.Deployment.Internal;

namespace System.ServiceProcess
{
    public interface IServiceProcessInstaller : IDisposable
    {
        ServiceAccount Account
        {
            get;
            set;
        }

        string Username
        {
            get;
            set;
        }

        string Password
        {
            get;
            set;
        }
    }
}