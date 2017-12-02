using Microsoft.AspNetCore.Mvc;
using Project.Solar.Flare.DTO;

namespace Project.Solar.Flare.Test.Api.Controllers
{
  public class PutPartsController : Controller
  {
    public PutPartsController()
    {
    }

    [HttpPut]
    public int CreateFromBody([FromBody] PartDto data)
    {
      return 1;
    }

    [HttpPut]
    public int CreateFromForm([FromForm] PartDto data)
    {
      return 1;
    }
  }
}
