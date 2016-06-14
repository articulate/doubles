namespace System.IO
{
    public sealed class DirectoryInfoWrapper : FileSystemInfoWrapper, IDirectoryInfo
    {
        public DirectoryInfoWrapper(DirectoryInfo directoryInfo)
            : base(directoryInfo)
        {
        }
    }
}