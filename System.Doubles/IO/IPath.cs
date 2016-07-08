namespace System.IO
{
    public interface IPath
    {
        string GetFileName(string path);

        string GetFileNameWithoutExtension(string path);

        string GetExtension(string path);
    }
}