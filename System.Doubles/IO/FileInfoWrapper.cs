namespace System.IO
{
    public sealed class FileInfoWrapper : FileSystemInfoWrapper, IFileInfo
    {
        public string DirectoryName => FileInfo.DirectoryName;

        public long Length => FileInfo.Length;

        public bool IsReadOnly => FileInfo.IsReadOnly;

        private FileInfo FileInfo => (FileInfo) fileSystemInfo;

        public FileInfoWrapper(FileInfo fileInfo)
            : base(fileInfo)
        {
        }

        public IFileInfo CopyTo(string destFileName, bool overwrite)
        {
            return new FileInfoWrapper(FileInfo.CopyTo(destFileName, overwrite));
        }
    }
}
