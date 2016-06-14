namespace System.IO
{
    public abstract class FileSystemInfoWrapper : IFileSystemInfo
    {
        public bool Exists => fileSystemInfo.Exists;

        public string Name => fileSystemInfo.Name;

        public string Extension => fileSystemInfo.Extension;

        public string FullName => fileSystemInfo.FullName;

        public FileAttributes Attributes
        {
            get
            {
                return fileSystemInfo.Attributes;
            }
            set
            {
                fileSystemInfo.Attributes = value;
            }
        }

        public DateTime CreationTime
        {
            get
            {
                return fileSystemInfo.CreationTime;
            }
            set
            {
                fileSystemInfo.CreationTime = value;
            }
        }

        public DateTime CreationTimeUtc
        {
            get
            {
                return fileSystemInfo.CreationTimeUtc;
            }
            set
            {
                fileSystemInfo.CreationTimeUtc = value;
            }
        }

        public DateTime LastAccessTime
        {
            get
            {
                return fileSystemInfo.LastAccessTime;
            }
            set
            {
                fileSystemInfo.LastAccessTime = value;
            }
        }

        public DateTime LastAccessTimeUtc
        {
            get
            {
                return fileSystemInfo.LastAccessTimeUtc;
            }
            set
            {
                fileSystemInfo.LastAccessTimeUtc = value;
            }
        }

        public DateTime LastWriteTime
        {
            get
            {
                return fileSystemInfo.LastWriteTime;
            }
            set
            {
                fileSystemInfo.LastWriteTime = value;
            }
        }

        public DateTime LastWriteTimeUtc
        {
            get
            {
                return fileSystemInfo.LastWriteTimeUtc;
            }
            set
            {
                fileSystemInfo.LastWriteTimeUtc = value;
            }
        }

        protected readonly FileSystemInfo fileSystemInfo;

        protected FileSystemInfoWrapper(FileSystemInfo fileSystemInfo)
        {
            this.fileSystemInfo = fileSystemInfo;
        }
    }
}