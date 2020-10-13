using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EcommeranceWebApp.Helpers
{
    public interface IConnectionApiClient
    {
        public HttpClient Initial();
    }
}
