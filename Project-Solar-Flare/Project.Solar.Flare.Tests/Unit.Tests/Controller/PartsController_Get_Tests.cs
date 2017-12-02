using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Project.Solar.Flare.Tests.Unit.Tests.Infrastructure;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Project.Solar.Flare.DTO;

namespace Project.Solar.Flare.Tests.Unit.Tests.Controller
{
  [TestFixture]
  public class PartsController_Put_Tests : BaseTest
  {

    [TestCase]
    public async Task Parts_Get_ListOfPartsDto()
    {
      var response = await Context.Client.GetAsync("api/GetParts/Get/");

      response.EnsureSuccessStatusCode();
      var result = JsonConvert.DeserializeObject<List<PartDto>>(await response.Content.ReadAsStringAsync());

      Assert.That(result.FirstOrDefault(), Is.Not.Null);
      Assert.That(result.FirstOrDefault().Id, Is.EqualTo(0));
    }

    [TestCase("api/GetParts/GetFromRoute/1", 1)]
    [TestCase("api/GetParts/GetFromQuery?id=2", 2)]
    public async Task Parts_Get_PartDto(string path, int id)
    {
      var response = await Context.Client.GetAsync(path);

      response.EnsureSuccessStatusCode();
      var result = JsonConvert.DeserializeObject<PartDto>(await response.Content.ReadAsStringAsync());

      Assert.That(result, Is.Not.Null);
      Assert.That(result.Id, Is.EqualTo(id));
    }
  }
}
