namespace System.IO
{
    public sealed class FileSystemWrapper : IFileSystem
    {
        public IDirectoryInfo CreateDirectory(string directoryPath)
        {
            return new DirectoryInfoWrapper(Directory.CreateDirectory(directoryPath));
        }

        public bool DirectoryExists(string directoryPath)
        {
            return Directory.Exists(directoryPath);
        }

        public string[] DirectoryGetDirectories(string directoryPath, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetDirectories(directoryPath, searchPattern, searchOption);
        }

        public string[] DirectoryGetFiles(string directoryPath, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetFiles(directoryPath, searchPattern, searchOption);
        }

        public void FileCopy(string sourceFileName, string destinationFileName, bool overwrite)
        {
            File.Copy(sourceFileName, destinationFileName, overwrite);
        }

        public StreamWriter FileCreateText(string filePath)
        {
            return File.CreateText(filePath);
        }

        public Stream FileCreate(string filePath)
        {
            return File.Create(filePath);
        }

        public void FileDelete(string filePath)
        {
            File.Delete(filePath);
        }

        public bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public void FileMove(string sourceFilePath, string destinationFilePath)
        {
            File.Move(sourceFilePath, destinationFilePath);
        }

        public byte[] FileReadAllBytes(string filePath)
        {
            return File.ReadAllBytes(filePath);
        }

        public void FileWriteAllText(string path, string text)
        {
            File.WriteAllText(path, text);
        }

        public string FileReadAllText(string path)
        {
            return File.ReadAllText(path);
        }

        public Stream FileOpen(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return File.Open(path, mode, access, share);
        }
    }
}