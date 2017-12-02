using Microsoft.AspNetCore.Mvc;

namespace Project.Solar.Flare.Test.Api.Controllers
{
  public class DeletePartsController : Controller
  {
    protected DeletePartsController()
    {
    }

    [HttpDelete]
    public int DeleteFromQuery([FromQuery] int id)
    {
      return 1;
    }

    [HttpDelete]
    public int DeleteFromRoute([FromRoute] int id)
    {
      return 1;
    }

    [HttpDelete]
    public int DeleteFromBody([FromBody] int id)
    {
      return 1;
    }
  }
}
