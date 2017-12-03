using Project.Solar.Flare.DTO;

namespace Project.Solar.Flare.Tests.Objects.ObjectBuilders
{
  public class PartBuilder
  {
    public PartDto PartDto { get; set; }

    public PartBuilder()
    {
    }

    public PartBuilder aPart()
    {
      PartDto = new PartDto();
      return this;
    }

    public PartBuilder WithId(int id)
    {
      PartDto.Id = id;
      return this;
    }

    public PartBuilder WithName(string name)
    {
      PartDto.Name = name;
      return this;
    }

    public PartBuilder WithSerialNumber(string serialNumber)
    {
      PartDto.SerialNumber = serialNumber;
      return this;
    }

    public PartBuilder WithType(PartType type)
    {
      PartDto.Type = type;
      return this;
    }
  }
}
