namespace System.IO
{
    public interface IStreamReader : IDisposable
    {
        bool EndOfStream
        {
            get;
        }

        string ReadLine();

        string ReadToEnd();
    }
}