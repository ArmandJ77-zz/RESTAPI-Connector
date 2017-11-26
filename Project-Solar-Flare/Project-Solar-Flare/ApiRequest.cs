using System.Collections.Generic;
using RestSharp;

namespace Project.Solar.Flare
{
  public class ApiRequest
  {
    public string Resource { get; set; }
    public string Token { get; set; }
    public Method Method { get; set; }
    public DataFormat DataFormat { get; set; }
    public object Body { get; set; }

    //private List<KeyValuePair<string, string>> _parameters;
    //public List<KeyValuePair<string, string>> Parameters
    //{
    //  get { return _parameters ?? (_parameters = new List<KeyValuePair<string, string>>()); }
    //  set { _parameters = value; }
    //}

    private List<KeyValuePair<string, string>> _headers;
    public List<KeyValuePair<string, string>> Headers
    {
      get { return _headers ?? (_headers = new List<KeyValuePair<string, string>>()); }
      set { _headers = value; }
    }

    //private IEnumerable<FileDto> _files;
    //public IEnumerable<FileDto> Files
    //{
    //  get { return _files ?? (_files = new List<FileDto>()); }
    //  set { _files = value; }
    //}

    public ApiRequest() { }

    public ApiRequest(string resource, object body = null, string token = "")
    {
      Resource = resource;
      Body = body;
      Token = token;
    }
  }
}
