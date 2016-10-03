using System.Collections.Generic;

namespace System.Net.Http
{
    public sealed class HttpRequestMessageWrapper : IHttpRequestMessage
    {
        public Version Version => httpRequestMessage.Version;

        public IHttpContent Content
        {
            get;
        }

        public HttpMethod Method => httpRequestMessage.Method;

        public Uri RequestUri => httpRequestMessage.RequestUri;

        public IDictionary<string, object> Properties => httpRequestMessage.Properties;

        private readonly HttpRequestMessage httpRequestMessage;

        public HttpRequestMessageWrapper(HttpRequestMessage httpRequestMessage)
        {
            this.httpRequestMessage = httpRequestMessage;

            Content = httpRequestMessage.Content == null ? null : new HttpContentWrapper(httpRequestMessage.Content);
        }

        public void Dispose() => httpRequestMessage.Dispose();

        public override bool Equals(object obj) => httpRequestMessage.Equals(obj);

        public override int GetHashCode() => httpRequestMessage.GetHashCode();

        public override string ToString() => httpRequestMessage.ToString();
    }
}