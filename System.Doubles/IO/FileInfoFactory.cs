namespace System.IO
{
    public sealed class FileInfoFactory : IFileInfoFactory
    {
        public IFileInfo Create(string filePath)
        {
            return new FileInfoWrapper(new FileInfo(filePath));
        }
    }
}