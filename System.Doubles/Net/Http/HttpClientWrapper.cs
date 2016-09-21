using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public sealed class HttpClientWrapper : IHttpClient
    {
        private readonly HttpClient httpClient;

        public HttpClientWrapper(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public void Dispose() => httpClient.Dispose();

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption httpCompletionOption, CancellationToken cancellationToken) => httpClient.SendAsync(request, httpCompletionOption, cancellationToken);
    }
}
