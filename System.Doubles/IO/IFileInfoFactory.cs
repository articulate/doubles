namespace System.IO
{
    public interface IFileInfoFactory
    {
        IFileInfo Create(string filePath);
    }
}