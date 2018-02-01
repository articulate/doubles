using System.Collections;
using System.Configuration.Install;

namespace System.ServiceProcess
{
    internal sealed class ServiceInstallerWrapper : IServiceInstaller
    {
        public InstallContext Context
        {
            get => serviceInstaller.Context;
            set => serviceInstaller.Context = value;
        }

        public IServiceProcessInstaller Parent
        {
            get => parent;
            set
            {
                parent = value;
                serviceInstaller.Parent = (parent as ServiceProcessInstallerWrapper)?.Wrapped;
            }
        }

        public ServiceStartMode StartType
        {
            get => serviceInstaller.StartType;
            set => serviceInstaller.StartType = value;
        }

        public string DisplayName
        {
            get => serviceInstaller.DisplayName;
            set => serviceInstaller.DisplayName = value;
        }

        public string ServiceName
        {
            get => serviceInstaller.ServiceName;
            set => serviceInstaller.ServiceName = value;
        }

        public string Description
        {
            get => serviceInstaller.Description;
            set => serviceInstaller.Description = value;
        }

        private IServiceProcessInstaller parent;
        private readonly ServiceInstaller serviceInstaller;

        public ServiceInstallerWrapper(ServiceInstaller serviceInstaller)
        {
            this.serviceInstaller = serviceInstaller;
        }

        public void Dispose()
        {
            serviceInstaller.Dispose();
        }

        public void Install(IDictionary stateSaver)
        {
            serviceInstaller.Install(stateSaver);
        }

        public void Uninstall(IDictionary savedState)
        {
            serviceInstaller.Uninstall(savedState);
        }

        public void Rollback(IDictionary savedState)
        {
            serviceInstaller.Rollback(savedState);
        }
    }
}