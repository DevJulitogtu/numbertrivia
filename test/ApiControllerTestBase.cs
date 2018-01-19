using System.IO;
using System.Net.Http;
using api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace test
{
    public class ApiControllerTestBase
    {
        protected HttpClient GetClient()
        {
            var builder = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseEnvironment("Testing");

            var server = new TestServer(builder);
            var client = server.CreateClient();

            return client;
        }
    }
}