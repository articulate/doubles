using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public interface IHttpClient : IDisposable
    {
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption httpCompletionOption, CancellationToken cancellationToken);
    }
}