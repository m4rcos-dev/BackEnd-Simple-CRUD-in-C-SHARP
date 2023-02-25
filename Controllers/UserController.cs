using Microsoft.AspNetCore.Mvc;
namespace BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Controllers
{

  [ApiController]
  [Route("/users")]
  public class UserController : ControllerBase
  {
    [HttpGet]
    public string Get()
    {
      return "Ok";
    }
  }
}
