namespace System.Diagnostics
{
    public interface IFileVersionInfoFactory
    {
        IFileVersionInfo Create(string filePath);
    }
}