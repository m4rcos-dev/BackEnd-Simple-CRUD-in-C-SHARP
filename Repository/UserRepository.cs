using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Models;

namespace BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Repository
{
  public class UserRepository : IUserRepository
  {
    public void CreateUser(UserModel user)
    {
      throw new NotImplementedException();
    }

    public void DeleteUser(UserModel user)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<UserModel>> GetAllUsers()
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<UserModel>> GetById(int id)
    {
      throw new NotImplementedException();
    }

    public void UpdateUser(UserModel user)
    {
      throw new NotImplementedException();
    }
  }
}
