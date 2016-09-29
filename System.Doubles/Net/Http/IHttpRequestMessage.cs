using System.Collections.Generic;

namespace System.Net.Http
{
    public interface IHttpRequestMessage : IDisposable
    {
        Version Version
        {
            get;
        }

        IHttpContent Content
        {
            get;
        }

        HttpMethod Method
        {
            get;
        }

        Uri RequestUri
        {
            get;
        }

        IDictionary<string, object> Properties
        {
            get;
        }
    }
}