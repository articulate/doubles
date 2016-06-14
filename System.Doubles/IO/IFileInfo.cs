namespace System.IO
{
    public interface IFileInfo : IFileSystemInfo
    {
        string DirectoryName
        {
            get;
        }

        long Length
        {
            get;
        }

        bool IsReadOnly
        {
            get;
        }

        IFileInfo CopyTo(string destFileName, bool overwrite);
    }
}
