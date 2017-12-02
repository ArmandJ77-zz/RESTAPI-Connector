//using NUnit.Framework;
//using Project.Solar.Flare.Tests.Test.Objects;
//using System.Net;
//using System.Threading.Tasks;

//namespace Project.Solar.Flare.Tests.Unit.Tests
//{
//  [TestFixture]
//  class ApiRequestService_Post_Tests
//  {
//    public ApiRequestService ApiService { get; set; }

//    public ApiRequestService_Post_Tests()
//    {
//      ApiService = new ApiRequestService("https://reqres.in/");
//    }

//    //[TestCase]
//    //public async Task Post_Response_201()
//    //{
//    //  var response = await ApiService.PostAsync(new ApiRequest("/api/users"));

//    //  Assert.AreEqual(response.ResponseUri.AbsolutePath, "/api/users");
//    //  Assert.AreEqual(response.StatusCode, HttpStatusCode.Created);
//    //}

//    [TestCase]
//    public async Task PostBody_Response_TestUserResponseDto()
//    {
//      var body = new TestUserRequestDto { name = "morpheus", job = "leader" };
//      var response = await ApiService.PostAsync<TestUserResponseDto>(new ApiRequest("/api/users", body));

//      Assert.AreEqual(response, HttpStatusCode.Created);
//      Assert.AreNotEqual(response, null);
//      Assert.AreEqual(response.name, body.name);
//    }
//  }
//}
