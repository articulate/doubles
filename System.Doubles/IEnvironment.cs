namespace System
{
    public interface IEnvironment
    {
        IOperatingSystem OSVersion
        {
            get;
        }

        bool Is64BitOperatingSystem
        {
            get;
        }

        Version FrameworkVersion
        {
            get;
        }

        int TickCount
        {
            get;
        }

        string UserName
        {
            get;
        }

        string MachineName
        {
            get;
        }

        void Exit(int exitCode);

        string GetFolderPath(Environment.SpecialFolder specialFolder);
    }
}