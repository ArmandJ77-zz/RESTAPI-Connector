using Microsoft.AspNetCore.Mvc;
using Project.Solar.Flare.DTO;

namespace Project.Solar.Flare.Test.Api.Controllers
{
  [Route("api/[controller]/[action]")]
  public class PutPartsController : Controller
  {
    public PutPartsController()
    {
      
    }

    [HttpPut]
    public int FromBody([FromBody] PartDto data)
    {
      return 1;
    }

    [HttpPut]
    public int FromForm([FromForm] PartDto data)
    {
      return 1;
    }
  }
}
