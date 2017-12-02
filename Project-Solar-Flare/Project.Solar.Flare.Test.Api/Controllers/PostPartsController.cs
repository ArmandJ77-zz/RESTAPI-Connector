using Microsoft.AspNetCore.Mvc;
using Project.Solar.Flare.DTO;

namespace Project.Solar.Flare.Test.Api.Controllers
{
  public class PostPartsController : Controller
  {
    public PostPartsController()
    {
    }

    [HttpPost]
    public int CreateFromBody([FromBody] PartDto data)
    {
      return 1;
    }

    [HttpPost]
    public int CreateFromForm([FromForm] PartDto data)
    {
      return 1;
    }
  }
}
