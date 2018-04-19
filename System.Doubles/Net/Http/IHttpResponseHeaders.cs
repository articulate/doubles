using System.Net.Http.Headers;

namespace System.Net.Http
{
    public interface IHttpResponseHeaders
    {
        EntityTagHeaderValue ETag
        {
            get;
        }

        Uri Location
        {
            get;
        }
    }
}