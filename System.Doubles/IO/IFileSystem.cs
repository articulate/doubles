namespace System.IO
{
    public interface IFileSystem
    {
        IDirectoryInfo CreateDirectory(string directoryPath);

        bool DirectoryExists(string directoryPath);

        string[] DirectoryGetDirectories(string directoryPath, string searchPattern, SearchOption searchOption);

        string[] DirectoryGetFiles(string directoryPath, string searchPattern, SearchOption searchOption);

        void FileCopy(string sourceFileName, string destinationFileName, bool overwrite);

        StreamWriter FileCreateText(string filePath);

        Stream FileCreate(string filePath);

        void FileDelete(string filePath);

        bool FileExists(string filePath);

        void FileMove(string sourceFilePath, string destinationFilePath);

        byte[] FileReadAllBytes(string filePath);

        void FileWriteAllText(string path, string text);

        string FileReadAllText(string path);

        Stream FileOpen(string path, FileMode mode, FileAccess access, FileShare share);

        DateTime FileGetLastWriteTimeUtc(string path);
    }
}