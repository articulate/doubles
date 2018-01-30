using System.Collections;
using System.Configuration.Install;

namespace System.ServiceProcess
{
    public interface IServiceInstaller : IDisposable
    {
        InstallContext Context
        {
            get;
            set;
        }

        IServiceProcessInstaller Parent
        {
            get;
            set;
        }

        ServiceStartMode StartType
        {
            get;
            set;
        }

        string DisplayName
        {
            get;
            set;
        }

        string ServiceName
        {
            get;
            set;
        }

        void Install(IDictionary stateSaver);

        void Uninstall(IDictionary savedState);

        void Rollback(IDictionary savedState);
    }
}