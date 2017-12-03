using NUnit.Framework;
using Project.Solar.Flare.Tests.Integration.Tests.Infrastructure;
using Project.Solar.Flare.Tests.Objects.ObjectMothers;
using System.Threading.Tasks;

namespace Project.Solar.Flare.Tests.Integration.Tests.Controller
{
  [TestFixture]
  public class PartsController_Delete_Tests : BaseTest
  {
    [TestCase]
    public async Task Parts_Delete_Id()
    {
      var response = await Context.Client.DeleteAsync($"{PathObjectMother.DeletePartsPath.DeletePath}/1");
      response.EnsureSuccessStatusCode();
      var result = await response.Content.ReadAsStringAsync();

      Assert.That(result, Is.Not.Null);
      Assert.That(result, Is.EqualTo("1"));
    }
  }
}
