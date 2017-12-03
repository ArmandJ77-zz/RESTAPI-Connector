//using NUnit.Framework;
//using System.Net;
//using System.Threading.Tasks;
//using Project.Solar.Flare.Tests.Test.Objects;

//namespace Project.Solar.Flare.Tests.Unit.Tests
//{
//  [TestFixture]
//  public class ApiRequestService_Get_Tests
//  {
//    public ApiRequestService ApiService { get; set; }

//    public ApiRequestService_Get_Tests()
//    {
//      ApiService = new ApiRequestService("https://reqres.in/");
//    }

//    [TestCase]
//    public async Task Get_Response_String()
//    {
//      var response = await ApiService.GetAsync(new ApiRequest("/api/unknown"));

//      Assert.AreEqual(response.ResponseUri.AbsolutePath, "/api/unknown");
//      Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
//      Assert.AreEqual(!string.IsNullOrEmpty(response.Content), true);
//    }

//    [TestCase]
//    public async Task GetParameter_Response_String()
//    {
//      var response = await ApiService.GetAsync(new ApiRequest("/api/users?pages=2"));

//      Assert.AreEqual(response.ResponseUri.AbsolutePath, "/api/users");
//      Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
//      Assert.AreEqual(!string.IsNullOrEmpty(response.Content), true);
//    }

//    [TestCase]
//    public async Task GetUrlSegment_Response_UserResponseDto()
//    {
//      //var response = await ApiService.GetAsync<TestDataUserResponseDto>(new ApiRequest($"/api/users/{2}"));

//      //Assert.AreNotEqual(response.data, null);
//      //Assert.AreNotEqual(response.data.first_name, null);
//    }
//  }
//}
