using RestSharp;

namespace Project.Solar.Flare
{
  public class ApiRequestBuilder
  {
    //, params FileDto[] files
    public static RestRequest Build(ApiRequest apiRequest)
    {
      var restRequest = new RestRequest(apiRequest.Resource, apiRequest.Method);

      if (!string.IsNullOrEmpty(apiRequest.Token))
        restRequest.AddHeader("Authorization", apiRequest.Token);

      apiRequest.Headers.ForEach(header => restRequest.AddHeader(header.Key, header.Value));
      //apiRequest.Parameters.ForEach(param => restRequest.AddParameter(param.Key, param.Value));

      //foreach (var file in files)
      //  request.AddFile(file.FormKeyName, file.Content, file.Name, file.ContentType);

      //if (files.Any())
      //{
      //  request.AlwaysMultipartFormData = true;
      //  request.AddObject(dto.Body);
      //}else

      if (apiRequest.Body == null)
        return restRequest;

      restRequest.RequestFormat = apiRequest.DataFormat;
      restRequest.AddBody(apiRequest.Body);

      return restRequest;
    }
  }
}
