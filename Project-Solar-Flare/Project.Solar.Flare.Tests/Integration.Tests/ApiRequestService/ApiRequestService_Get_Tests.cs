using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Project.Solar.Flare.DTO;
using Project.Solar.Flare.Tests.Integration.Tests.Infrastructure;
using Project.Solar.Flare.Tests.Objects.ObjectMothers;

namespace Project.Solar.Flare.Tests.Unit.Tests
{
  [TestFixture]
  public class ApiRequestService_Get_Tests : BaseTest
  {
    public ApiRequestService_Get_Tests()
    {
    }
    //Can't use testserver as the Apiservice uses restsharp client and not the 
    [TestCase]
    public async Task Get_Response_String()
    {
      //var response = await Context.Client.GetAsync("api/GetParts/Get/");

      //response.EnsureSuccessStatusCode();
      //var result = JsonConvert.DeserializeObject<List<PartDto>>(await response.Content.ReadAsStringAsync());

      //Assert.That(result.FirstOrDefault(), Is.Not.Null);
      //Assert.That(result.FirstOrDefault().Id, Is.EqualTo(0));

      //var response = await Context.ApiService.GetAsync(new ApiRequest($"http://localhost:63840/api/GetParts/Get/"));
      ////var resp = await Context.ApiService.GetAsync(new ApiRequest($"{PathObjectMother.GetPartsPath.GetPath}"));

      ////Assert.AreEqual(response.ResponseUri.AbsolutePath, "/api/unknown");
      //Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
      //Assert.AreEqual(!string.IsNullOrEmpty(response.Content), true);
    }

    //[TestCase]
    //public async Task GetParameter_Response_String()
    //{
    //  var response = await ApiService.GetAsync(new ApiRequest("/api/users?pages=2"));

    //  Assert.AreEqual(response.ResponseUri.AbsolutePath, "/api/users");
    //  Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
    //  Assert.AreEqual(!string.IsNullOrEmpty(response.Content), true);
    //}

    [TestCase]
    public async Task GetUrlSegment_Response_UserResponseDto()
    {
      //var response = await ApiService.GetAsync<TestDataUserResponseDto>(new ApiRequest($"/api/users/{2}"));

      //Assert.AreNotEqual(response.data, null);
      //Assert.AreNotEqual(response.data.first_name, null);
    }
  }
}
