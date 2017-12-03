namespace Project.Solar.Flare.Tests.Objects.ObjectMothers
{
  public static class PathObjectMother
  {
    public static string TestServerBaseUrl => "http://localhost";


    public static GetPartsControllerPaths GetPartsPath => new GetPartsControllerPaths();
    public static PostPartsControllerPaths PostPartsPath => new PostPartsControllerPaths();
    public static PutPartsControllerPaths PutPartsPath => new PutPartsControllerPaths();
    public static DeletePartsControllerPaths DeletePartsPath => new DeletePartsControllerPaths();
  }

  public class GetPartsControllerPaths
  {
    public string GetPath = $"{PathObjectMother.TestServerBaseUrl}/api/GetParts/Get";
    public string GetFromRoutePath = $"{PathObjectMother.TestServerBaseUrl}/api/GetParts/GetFromRoute";
    public string GetFromQueryPath = $"{PathObjectMother.TestServerBaseUrl}/api/GetParts/GetFromQuery";
  }

  public class PostPartsControllerPaths
  {
    public string PostCreateFromBodyPath = $"{PathObjectMother.TestServerBaseUrl}/api/PostParts/CreateFromBody";
    public string PostCreateFromFormPath = $"{PathObjectMother.TestServerBaseUrl}/api/PostParts/CreateFromForm";
  }

  public class PutPartsControllerPaths
  {
    public string PutFromBodyPath = $"{PathObjectMother.TestServerBaseUrl}/api/PutParts/FromBody";
    public string PutFromRoutePath = $"{PathObjectMother.TestServerBaseUrl}/api/PutParts/FromForm";
  }

  public class DeletePartsControllerPaths
  {
    public string DeletePath = $"{PathObjectMother.TestServerBaseUrl}/api/DeleteParts/Delete";
  }
}
