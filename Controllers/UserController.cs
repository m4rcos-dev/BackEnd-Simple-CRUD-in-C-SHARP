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
      catch (Exception error)
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
      catch (Exception error)
      {
        var typeError = error.Data == null || error.Data.Count == 0;
        return typeError ? NotFound("User not found") : BadRequest(error.Message);
      }
    }

    [HttpPost]
    public async Task<IActionResult> Post(UserModel user)
    {
      try
      {
        if (user.Name == null || user.Name == "") throw new Exception("name field required");
        if (user.Ocupation == null || user.Ocupation == "") throw new Exception("ocupation field required");

        _repository.CreateUser(user);
        await _repository.SaveChangeAsync();

        return Ok("Registered user");
      }
      catch(Exception error)
      {
        return BadRequest(error.Message);
      }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UserModel userUpdate)
    {
      try
      {
        var user = await _repository.GetById(id);

        user.Name = userUpdate.Name == null || userUpdate.Name == "" ? user.Name : userUpdate.Name;
        user.Ocupation = userUpdate.Ocupation == null || userUpdate.Ocupation == "" ? user.Ocupation : userUpdate.Ocupation;

        _repository.UpdateUser(user);
        await _repository.SaveChangeAsync();

        return Ok("Updated user");
      }
      catch (Exception error)
      {
        var typeError = error.Data == null || error.Data.Count == 0;
        return typeError ? NotFound("User not found") : BadRequest(error.Message);
      }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      try
      {
        var user = await _repository.GetById(id);

        _repository.DeleteUser(user);
        await _repository.SaveChangeAsync();

        return Ok("Deleted user");
      }
      catch (Exception error)
      {
        var typeError = error.Data == null || error.Data.Count == 0;
        return typeError ? NotFound("User not found") : BadRequest(error.Message);
      }
    }
  }
}
