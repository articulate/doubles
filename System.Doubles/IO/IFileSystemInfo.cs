namespace System.IO
{
    public interface IFileSystemInfo
    {
        bool Exists
        {
            get;
        }

        string Name
        {
            get;
        }

        string Extension
        {
            get;
        }

        string FullName
        {
            get;
        }

        FileAttributes Attributes
        {
            get;
            set;
        }

        DateTime CreationTime
        {
            get;
            set;
        }

        DateTime CreationTimeUtc
        {
            get;
            set;
        }

        DateTime LastAccessTime
        {
            get;
            set;
        }

        DateTime LastAccessTimeUtc
        {
            get;
            set;
        }

        DateTime LastWriteTime
        {
            get;
            set;
        }

        DateTime LastWriteTimeUtc
        {
            get;
            set;
        }
    }
}