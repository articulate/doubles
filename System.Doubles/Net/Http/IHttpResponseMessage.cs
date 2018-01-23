namespace System.Net.Http
{
    public interface IHttpResponseMessage : IDisposable
    {
        Version Version
        {
            get;
        }

        IHttpContent Content
        {
            get;
        }

        HttpStatusCode StatusCode
        {
            get;
        }

        string ReasonPhrase
        {
            get;
        }

        IHttpRequestMessage RequestMessage
        {
            get;
        }

        bool IsSuccessStatusCode
        {
            get;
        }

        IHttpResponseHeaders ResponseHeaders
        {
            get;
        }
    }
}