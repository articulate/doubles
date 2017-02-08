using System.IO.Compression;
using System.Text;

namespace System.IO
{
    public class ZipFileWrapper : IZipFile
    {
        public void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding)
        {
            ZipFile.CreateFromDirectory(sourceDirectoryName, destinationArchiveFileName, compressionLevel, includeBaseDirectory, entryNameEncoding);
        }
    }
}