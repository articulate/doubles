using System.IO;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public sealed class HttpContentWrapper : IHttpContent
    {
        public long? Length => httpContent.Headers.ContentLength;

        public string ContentType => httpContent.Headers.ContentType?.MediaType;

        private readonly HttpContent httpContent;

        public HttpContentWrapper(HttpContent httpContent)
        {
            this.httpContent = httpContent;
        }

        public Task<Stream> ReadAsStreamAsync() => httpContent.ReadAsStreamAsync();
    }
}