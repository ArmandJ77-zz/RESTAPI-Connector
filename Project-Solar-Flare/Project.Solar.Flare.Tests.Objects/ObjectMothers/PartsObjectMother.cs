using System.Collections.Generic;
using Project.Solar.Flare.DTO;

namespace Project.Solar.Flare.Tests.Test.Objects.ObjectMothers
{
  public class PartsObjectMother
  {
    public List<PartDto> AListOfPartDtos => new List<PartDto>
      {
        new PartDto
        {
          Id = 0,
          Name = "Razer BlackWidow Ultimate",
          SerialNumber = "RZRBWU",
          Type = PartType.Keyboard
        },
        new PartDto
        {
          Id = 1,
          Name = "Razer Ouroboros",
          SerialNumber = "RZRORBR",
          Type = PartType.Mouse
        },
        new PartDto
        {
          Id = 2,
          Name = "Razer Kraken 7.1 V2",
          SerialNumber = "RZRKV2",
          Type = PartType.Headsets
        },

      };
  }
}
