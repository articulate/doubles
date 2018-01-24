using System.Net.Http.Headers;

namespace System.Net.Http
{
    internal sealed class HttpResponseHeadersWrapper : IHttpResponseHeaders
    {
        public Uri Location => httpResponseHeaders.Location;

        private readonly HttpResponseHeaders httpResponseHeaders;

        public HttpResponseHeadersWrapper(HttpResponseHeaders httpResponseHeaders)
        {
            this.httpResponseHeaders = httpResponseHeaders;
        }
    }
}