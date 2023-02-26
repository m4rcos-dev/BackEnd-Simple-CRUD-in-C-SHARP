using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Data;
using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Repository
{
  public class UserRepository : IUserRepository
  {
    private readonly UserContext _context;

    public UserRepository(UserContext context)
    {
      _context = context;
    }

    public Task<List<UserModel>> GetAllUsers()
    {
      return Task.FromResult(_context.Users.ToList());
    }

    public  Task<UserModel> GetById(int id)
    {
      return _context.Users.FirstAsync(x => x.Id == id);
    }

    public void CreateUser(UserModel user)
    {
      _context.Add(user);
    }

    public void UpdateUser(UserModel user)
    {
      _context.Update(user);
    }

    public void DeleteUser(UserModel user)
    {
      _context.Remove(user);
    }

    public async Task<bool> SaveChangeAsync()
    {
      return await _context.SaveChangesAsync() > 0;
    }
  }
}
