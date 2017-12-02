namespace Project.Solar.Flare.Tests.Objects.ObjectBuilders
{
  public class PartBuilder
  {
    private PartBuilder()
    {
    }
    
    public static PartBuilder aPart()
    {
      return new PartBuilder();
    }
  }
}
