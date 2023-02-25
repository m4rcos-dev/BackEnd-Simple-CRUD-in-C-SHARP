using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Repository;
using Microsoft.AspNetCore.Mvc;
namespace BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Controllers
{

  [ApiController]
  [Route("/users")]
  public class UserController : ControllerBase
  {
    private readonly IUserRepository _repository;

    public UserController(IUserRepository repository)
    {
      _repository = repository;
    }

    [HttpGet]
    public string Get()
    {
      return "Ok";
    }
  }
}
