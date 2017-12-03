using Newtonsoft.Json;
using NUnit.Framework;
using Project.Solar.Flare.DTO;
using Project.Solar.Flare.Tests.Integration.Tests.Infrastructure;
using Project.Solar.Flare.Tests.Objects.ObjectBuilders;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Project.Solar.Flare.Tests.Integration.Tests.Controller
{
  [TestFixture]
  public class PartsController_Post_Tests : BaseTest
  {
    [TestCase]
    public async Task Parts_BodyPost_Id()
    {
      Context.Client.DefaultRequestHeaders
       .Accept
       .Add(new MediaTypeWithQualityHeaderValue("application/json"));

      var stringContent = new StringContent(JsonConvert.SerializeObject(
          new PartBuilder().aPart()
          .WithId(1)
          .WithName("QWERTY")
          .WithSerialNumber("ASDF")
          .WithType(PartType.Mouse)
          .PartDto).ToString(),
        Encoding.UTF8,
        "application/json");

      var response = await Context.Client.PostAsync("api/PostParts/CreateFromBody", stringContent);

      response.EnsureSuccessStatusCode();
      var result = await response.Content.ReadAsStringAsync();

      Assert.That(result, Is.Not.Null);
      Assert.That(result, Is.EqualTo("1"));
    }

    [TestCase]
    public async Task Parts_FormPost_Id()
    {
      using (var multipartFormDataContent = new MultipartFormDataContent())
      {
        var values = new[]
        {
                new KeyValuePair<string, string>("Id", "1"),
                new KeyValuePair<string, string>("Name", "QWERTY"),
                new KeyValuePair<string, string>("SerialNumber", "ASDF"),
                new KeyValuePair<string, string>("Type", PartType.Mouse.ToString())
        };

        foreach (var keyValuePair in values)
        {
          multipartFormDataContent.Add(new StringContent(keyValuePair.Value),
              String.Format("\"{0}\"", keyValuePair.Key));
        }

        var response = await Context.Client.PostAsync("api/PostParts/CreateFromForm", multipartFormDataContent);
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadAsStringAsync();

        Assert.That(result, Is.Not.Null);
        Assert.That(result, Is.EqualTo("1"));
      }
    }
  }
}
