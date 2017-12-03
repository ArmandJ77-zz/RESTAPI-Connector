using Project.Solar.Flare.DTO;

namespace Project.Solar.Flare.Tests.Objects.ObjectBuilders
{
  public class PartDeleteBuilder
  {
    public PartDeleteDto PartDeleteDto { get; set; }

    public PartDeleteBuilder aPartDeleteDto()
    {
      this.PartDeleteDto = new PartDeleteDto();
      return this;
    }

    public PartDeleteBuilder WithId(int id)
    {
      this.PartDeleteDto.Id = id;
      return this;
    }
  }
}
