using Microsoft.AspNetCore.Mvc;
using Project.Solar.Flare.DTO;

namespace Project.Solar.Flare.Test.Api.Controllers
{
  [Route("api/[controller]/[action]")]
  public class PostPartsController : Controller
  {
    [HttpPost]
    public int CreateFromBody([FromBody] PartDto data)
      => 1;

    [HttpPost]
    public int CreateFromForm([FromForm] PartDto data)
      => 1;
  }
}
