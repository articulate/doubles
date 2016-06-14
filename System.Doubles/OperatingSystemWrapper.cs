namespace System
{
    internal sealed class OperatingSystemWrapper : IOperatingSystem
    {
        public string VersionString => Environment.OSVersion.VersionString;

        public PlatformID Platform => Environment.OSVersion.Platform;

        public Version Version => Environment.OSVersion.Version;

        public string ServicePack => Environment.OSVersion.ServicePack;
    }
}