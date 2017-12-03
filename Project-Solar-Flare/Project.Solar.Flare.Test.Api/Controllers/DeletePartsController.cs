using Microsoft.AspNetCore.Mvc;

namespace Project.Solar.Flare.Test.Api.Controllers
{
  [Route("api/[controller]/[action]")]
  public class DeletePartsController : Controller
  {
    public DeletePartsController()
    {
    }

    [HttpDelete("{id}")]
    public int Delete(int id)
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
