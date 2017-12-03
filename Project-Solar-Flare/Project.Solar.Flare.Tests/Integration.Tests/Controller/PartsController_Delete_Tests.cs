using NUnit.Framework;
using Project.Solar.Flare.Tests.Integration.Tests.Infrastructure;
using System.Threading.Tasks;

namespace Project.Solar.Flare.Tests.Integration.Tests.Controller
{
  [TestFixture]
  public class PartsController_Delete_Tests : BaseTest
  {
    [TestCase("api/DeleteParts/Delete/1", "1")]
    public async Task Parts_Delete_Id(string path, string id)
    {
      var response = await Context.Client.DeleteAsync(path);
      response.EnsureSuccessStatusCode();
      var result = await response.Content.ReadAsStringAsync();

      Assert.That(result, Is.Not.Null);
      Assert.That(result, Is.EqualTo(id));
    }
  }
}
