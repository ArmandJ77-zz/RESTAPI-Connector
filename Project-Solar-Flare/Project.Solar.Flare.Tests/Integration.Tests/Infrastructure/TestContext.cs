using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Project.Solar.Flare.Test.Api;
using System;
using System.Net.Http;
using Project.Solar.Flare.Tests.Objects.ObjectMothers;

namespace Project.Solar.Flare.Tests.Integration.Tests.Infrastructure
{
  public class TestContext : IDisposable
  {
    private TestServer _server;
    public HttpClient Client { get; private set; }
    public ApiRequestService ApiService { get; set; }

    public TestContext()
    {
      SetUpClient();
    }

    private void SetUpClient()
    {
      _server = new TestServer(new WebHostBuilder()
        .UseStartup<Startup>())
      { BaseAddress = new Uri(PathObjectMother.TestServerBaseUrl) };

      Client = _server.CreateClient();
      ApiService = new ApiRequestService(PathObjectMother.TestServerBaseUrl);
    }

    public void Dispose()
    {
      _server?.Dispose();
      Client?.Dispose();
    }
  }
}
