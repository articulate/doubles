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

        public IHttpResponseHeaders ResponseHeaders
        {
            get;
        }

        private readonly HttpResponseMessage httpResponseMessage;

        public HttpResponseMessageWrapper(HttpResponseMessage httpResponseMessage)
        {
            this.httpResponseMessage = httpResponseMessage;

            Content = httpResponseMessage.Content == null ? null : new HttpContentWrapper(httpResponseMessage.Content);
            RequestMessage = httpResponseMessage.RequestMessage == null ? null : new HttpRequestMessageWrapper(httpResponseMessage.RequestMessage);
            ResponseHeaders = new HttpResponseHeadersWrapper(httpResponseMessage.Headers);
        }

        public void Dispose() => httpResponseMessage.Dispose();

        public override bool Equals(object obj)
        {
            var other = obj as HttpResponseMessageWrapper;

            return httpResponseMessage.Equals(other != null ? other.httpResponseMessage : obj);
        }

        public override int GetHashCode() => httpResponseMessage.GetHashCode();

        public override string ToString() => httpResponseMessage.ToString();
    }
}