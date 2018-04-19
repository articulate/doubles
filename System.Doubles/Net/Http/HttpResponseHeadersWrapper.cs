using System.Net.Http.Headers;

namespace System.Net.Http
{
    internal sealed class HttpResponseHeadersWrapper : IHttpResponseHeaders
    {
        public EntityTagHeaderValue ETag => httpResponseHeaders.ETag;

        public Uri Location => httpResponseHeaders.Location;

        private readonly HttpResponseHeaders httpResponseHeaders;

        public HttpResponseHeadersWrapper(HttpResponseHeaders httpResponseHeaders)
        {
            this.httpResponseHeaders = httpResponseHeaders;
        }
    }
}