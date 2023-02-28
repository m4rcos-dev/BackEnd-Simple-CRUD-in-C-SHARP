using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Interfaces;
using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Models;
using Microsoft.AspNetCore.Mvc;
namespace BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Controllers
{

  [ApiController]
  [Route("/users")]
  public class UserController : ControllerBase
  {
    private readonly IUserServices _service;

    public UserController(IUserServices service)
    {
      _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var users = await _service.GetAllUsers();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var user = await _service.GetById(id);
        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> Post(UserModel user)
    {
        await _service.CreateUser(user);
        return Ok("Registered user");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UserModel userUpdate)
    {
        await _service.UpdateUser(userUpdate, id);
        return Ok("Updated user");

    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteUser(id);
        return Ok("Deleted user");
    }
  }
}
