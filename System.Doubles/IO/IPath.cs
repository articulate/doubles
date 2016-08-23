namespace System.IO
{
    public interface IPath
    {
        string GetFileName(string path);

        string GetFileNameWithoutExtension(string path);

        string GetExtension(string path);

        string Combine(string path1, string path2);

        string Combine(string path1, string path2, string path3);

        string Combine(string path1, string path2, string path3, string path4);

        string Combine(params string[] paths);
    }
}