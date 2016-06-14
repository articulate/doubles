namespace System
{
    public interface IOperatingSystem
    {
        string VersionString
        {
            get;
        }

        PlatformID Platform
        {
            get;
        }

        Version Version
        {
            get;
        }

        string ServicePack
        {
            get;
        }
    }
}