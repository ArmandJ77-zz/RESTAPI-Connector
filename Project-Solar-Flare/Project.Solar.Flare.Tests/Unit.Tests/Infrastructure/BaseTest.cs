using NUnit.Framework;

namespace Project.Solar.Flare.Tests.Unit.Tests.Infrastructure
{
  [TestFixture]
  public class BaseTest
  {
    public TestContext Context { get; set; }

    [OneTimeSetUp]
    public void SetUpFixture()
    {
      Context = new TestContext();
    }
  }
}
