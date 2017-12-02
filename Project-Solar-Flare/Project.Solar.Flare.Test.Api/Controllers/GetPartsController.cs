using Microsoft.AspNetCore.Mvc;
using Project.Solar.Flare.DTO;
using Project.Solar.Flare.Tests.Test.Objects.ObjectMothers;
using System.Collections.Generic;
using System.Linq;

namespace Project.Solar.Flare.Test.Api.Controllers
{
  [Route("api/[controller]/[action]")]
  public class GetPartsController : Controller
  {
    public GetPartsController()
    {
    }

    [HttpGet]
    public List<PartDto> Get()
      => new PartsObjectMother().AListOfPartDtos;

    //controller/action?id=1
    [HttpGet]
    public PartDto GetFromQuery([FromQuery] int id)
      => new PartsObjectMother().AListOfPartDtos.FirstOrDefault(x => x.Id == id);

    //controller/action/1
    [HttpGet("{id}")]
    public PartDto GetFromRoute([FromRoute] int id)
      => new PartsObjectMother().AListOfPartDtos.FirstOrDefault(x => x.Id == id);

  }
}
