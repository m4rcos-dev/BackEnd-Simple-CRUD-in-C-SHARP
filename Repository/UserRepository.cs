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

    public async Task<List<UserModel>> GetAllUsers()
    {
      return await _context.Users.ToListAsync();
    }

    public async Task<UserModel> GetById(int id)
    {
      return await _context.Users.FirstAsync(x => x.Id == id);
    }
    public async Task<UserModel> CreateUser(UserModel user)
    {
      var userDb = _context.Users.Add(user);
      await _context.SaveChangesAsync();
      return user;
    }

    public async Task<UserModel> UpdateUser(UserModel user, int id)
    {
      _context.Users.Update(user);
      await _context.SaveChangesAsync();

      return user;
    }

    public async Task<bool> DeleteUser(int id)
    {
      var userDb = await GetById(id);

      _context.Users.Remove(userDb);
      await _context.SaveChangesAsync();

      return true;
    }
  }
}
