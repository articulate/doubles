namespace System.Diagnostics
{
    public sealed class FileVersionInfoFactory : IFileVersionInfoFactory
    {
        public IFileVersionInfo Create(string filePath)
        {
            return new FileVersionInfoWrapper(FileVersionInfo.GetVersionInfo(filePath));
        }
    }
}