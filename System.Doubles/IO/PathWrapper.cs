namespace System.IO
{
    public sealed class PathWrapper : IPath
    {
        public string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }

        public string GetExtension(string path)
        {
            return Path.GetExtension(path);
        }
    }
}