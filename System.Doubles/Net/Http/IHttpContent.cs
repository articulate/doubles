using System.IO;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public interface IHttpContent
    {
        long? Length
        {
            get;
        }

        string ContentType
        {
            get;
        }

        Task<Stream> ReadAsStreamAsync();
    }
}