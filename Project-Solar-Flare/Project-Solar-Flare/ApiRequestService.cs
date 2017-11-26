using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;

namespace Project.Solar.Flare
{
  public class ApiRequestService
  {
    private RestClient Client { get; }

    public ApiRequestService(string baseUrl)
    {
      Client = new RestClient(baseUrl);
    }

    #region IRestResponse Results
    /// <summary>
    /// Returns the full IRestResponse object
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task<IRestResponse> GetAsync(ApiRequest dto)
      => await Task.Run(() => Client.Execute(ApiRequestBuilder.Build(dto)));

    /// <summary>
    /// Returns the full IRestResponse object
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task<IRestResponse> PostAsync(ApiRequest dto)
      => await Task.Run(() => Client.Execute(ApiRequestBuilder.Build(dto)));

    /// <summary>
    /// Returns the full IRestResponse object
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task<IRestResponse> PutAsync(ApiRequest dto)
      => await Task.Run(() => Client.Execute(ApiRequestBuilder.Build(dto)));

    /// <summary>
    /// Returns the full IRestResponse object
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task<IRestResponse> DeleteAsync(ApiRequest dto)
      => await Task.Run(() => Client.Execute(ApiRequestBuilder.Build(dto)));
    #endregion

    #region Deserialized IRestResponse
    /// <summary>
    /// Returns a json de-serialized result from the IRestResponse 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task<T> GetAsync<T>(ApiRequest dto)
      => await Task.Run(() => JsonConvert.DeserializeObject<T>(Client.Execute(ApiRequestBuilder.Build(dto)).Content));

    /// <summary>
    /// Returns a json de-serialized result from the IRestResponse 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task<T> PostAsync<T>(ApiRequest dto)
      => await Task.Run(() => JsonConvert.DeserializeObject<T>(Client.Execute(ApiRequestBuilder.Build(dto)).Content));

    /// <summary>
    /// Returns a json de-serialized result from the IRestResponse 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task<T> PutAsync<T>(ApiRequest dto)
      => await Task.Run(() => JsonConvert.DeserializeObject<T>(Client.Execute(ApiRequestBuilder.Build(dto)).Content));

    /// <summary>
    /// Returns a json de-serialized result from the IRestResponse 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task<T> DeleteAsync<T>(ApiRequest dto)
      => await Task.Run(() => JsonConvert.DeserializeObject<T>(Client.Execute(ApiRequestBuilder.Build(dto)).Content));
    #endregion
  }
}
