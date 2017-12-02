using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;
using Project.Solar.Flare.Test.Api;

namespace Project.Solar.Flare.Tests.Unit.Tests
{
  [TestFixture]
  public class PartsController_Put_Tests
  {
    private TestServer _server;
    public HttpClient Client { get; private set; }

    public PartsController_Put_Tests()
    {
      _server = new TestServer(new WebHostBuilder()
        .UseStartup<Startup>());

      Client = _server.CreateClient();
    }

    [TestCase]
    public async Task Parts_Get_ListOfPartsDto()
    {
      
    }
  }
}
