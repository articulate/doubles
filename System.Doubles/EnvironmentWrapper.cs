namespace System
{
    public sealed class EnvironmentWrapper : IEnvironment
    {
        public IOperatingSystem OSVersion
        {
            get;
        }

        public bool Is64BitOperatingSystem => Environment.Is64BitOperatingSystem;

        public Version FrameworkVersion => Environment.Version;

        public int TickCount => Environment.TickCount;

        public string UserName => Environment.UserName;

        public string MachineName => Environment.MachineName;

        public EnvironmentWrapper()
        {
            OSVersion = new OperatingSystemWrapper();
        }

        public void Exit(int exitCode)
        {
            Environment.Exit(exitCode);
        }

        public string GetFolderPath(Environment.SpecialFolder specialFolder)
        {
            return Environment.GetFolderPath(specialFolder);
        }
    }
}