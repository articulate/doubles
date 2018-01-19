namespace System.IO
{
    public sealed class StreamReaderWrapper : IStreamReader
    {
        public bool EndOfStream => streamReader.EndOfStream;

        private readonly StreamReader streamReader;

        public StreamReaderWrapper(StreamReader streamReader) => this.streamReader = streamReader;

        public void Dispose() => streamReader.Dispose();

        public string ReadLine() => streamReader.ReadLine();

        public string ReadToEnd() => streamReader.ReadToEnd();
    }
}
