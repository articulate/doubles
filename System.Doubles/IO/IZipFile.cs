using System.IO.Compression;
using System.Text;

namespace System.IO
{
    public interface IZipFile
    {
        void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding);
    }
}