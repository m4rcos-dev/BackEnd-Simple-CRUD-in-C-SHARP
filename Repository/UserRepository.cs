using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Data;
using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Models;

namespace BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Repository
{
  public class UserRepository : IUserRepository
  {
    private readonly UserContext _context;

    public UserRepository(UserContext context)
    {
      _context = context;
    }

    public Task<IEnumerable<UserModel>> GetAllUsers()
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<UserModel>> GetById(int id)
    {
      throw new NotImplementedException();
    }

    public void CreateUser(UserModel user)
    {
      _context.Add(user);
    }

    public void UpdateUser(UserModel user)
    {
      throw new NotImplementedException();
    }

    public void DeleteUser(UserModel user)
    {
      throw new NotImplementedException();
    }

    public async Task<bool> SaveChangeAsync()
    {
      return await _context.SaveChangesAsync() > 0;
    }
  }
}
