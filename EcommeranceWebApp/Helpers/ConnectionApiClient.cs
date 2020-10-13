using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EcommeranceWebApp.Helpers
{
    public class ConnectionApiClient : IConnectionApiClient
    {
        public IConfiguration configuration;

        public ConnectionApiClient(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(configuration.GetValue<string>("APIaddress"));
            return client;
        }
    }
}
