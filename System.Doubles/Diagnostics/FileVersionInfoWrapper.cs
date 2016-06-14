namespace System.Diagnostics
{
    public sealed class FileVersionInfoWrapper : IFileVersionInfo
    {
        public string FileVersion => fileVersionInfo.FileVersion;

        private readonly FileVersionInfo fileVersionInfo;

        public FileVersionInfoWrapper(FileVersionInfo fileVersionInfo)
        {
            this.fileVersionInfo = fileVersionInfo;
        }
    }
}