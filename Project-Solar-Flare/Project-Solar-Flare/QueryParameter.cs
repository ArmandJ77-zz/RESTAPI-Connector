using RestSharp;

namespace Project.Solar.Flare
{
  public class QueryParameter
  {
    public string Name { get; set; }
    public string Value { get; set; }
    public ParameterType Type { get; set; }
  }
}
