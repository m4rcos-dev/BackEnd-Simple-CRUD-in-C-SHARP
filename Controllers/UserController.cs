using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Models;
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
    public async Task<IActionResult> Get()
    {
      try
      {
        var users = await _repository.GetAllUsers();
        return Ok(users);
      }
      catch(Exception error)
      {
        return BadRequest(error.Message);
      }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      try
      {
        var user = await _repository.GetById(id);
        return Ok(user);
      }
      catch(Exception error)
      {
        var typeError = error.Data == null || error.Data.Count == 0;
        return typeError ? NotFound("User not found") : BadRequest(error.Message);
      }
    }

    [HttpPost]
    public async Task<IActionResult> Post(UserModel user)
    {
      _repository.CreateUser(user);
      return await _repository.SaveChangeAsync()
              ? Ok("Registered user")
              : BadRequest("Error registering user");
    }
  }
}
