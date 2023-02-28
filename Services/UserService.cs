using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Interfaces;
using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Models;
using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Repository;

namespace BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Services
{
  public class UserService : IUserServices
  {
    private readonly UserRepository _repository;

    public UserService(UserRepository repository)
    {
      _repository = repository;
    }

    public async Task<List<UserModel>> GetAllUsers()
    {
      return await _repository.GetAllUsers();
    }

    public Task<UserModel> GetById(int id)
    {
      return _repository.GetById(id);
    }

    public async Task<UserModel> CreateUser(UserModel user)
    {
      return await _repository.CreateUser(user);
    }

    public async Task<UserModel> UpdateUser(UserModel user, int id)
    {
      var userDb = await _repository.GetById(id);

      userDb.Name = user.Name ?? userDb.Name;
      userDb.Ocupation = user.Ocupation ?? userDb.Ocupation;

      return await _repository.UpdateUser(userDb);
    }

    public async Task<bool> DeleteUser(int id)
    {
      var userDb = await _repository.GetById(id);
      if (userDb == null) throw new Exception ("User Not Found");

      return await _repository.DeleteUser(id);
    }

  }
}
