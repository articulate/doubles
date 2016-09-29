namespace System.Net.Http
{
    public sealed class HttpResponseMessageWrapper : IHttpResponseMessage
    {
        public Version Version => httpResponseMessage.Version;

        public IHttpContent Content
        {
            get;
        }

        public HttpStatusCode StatusCode => httpResponseMessage.StatusCode;

        public string ReasonPhrase => httpResponseMessage.ReasonPhrase;

        public IHttpRequestMessage RequestMessage
        {
            get;
        }

        public bool IsSuccessStatusCode => httpResponseMessage.IsSuccessStatusCode;

        private readonly HttpResponseMessage httpResponseMessage;

        public HttpResponseMessageWrapper(HttpResponseMessage httpResponseMessage)
        {
            this.httpResponseMessage = httpResponseMessage;

            Content = httpResponseMessage.Content == null ? null : new HttpContentWrapper(httpResponseMessage.Content);
            RequestMessage = httpResponseMessage.RequestMessage == null ? null : new HttpRequestMessageWrapper(httpResponseMessage.RequestMessage);
        }

        public void Dispose() => httpResponseMessage.Dispose();

        public override string ToString() => httpResponseMessage.ToString();
    }
}