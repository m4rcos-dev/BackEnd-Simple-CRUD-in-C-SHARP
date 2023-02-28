using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Models;

namespace BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Interfaces
{
  public interface IUserServices
  {
    Task<List<UserModel>> GetAllUsers();
    Task<UserModel> GetById(int id);
    Task<UserModel> CreateUser(UserModel user);
    Task<UserModel> UpdateUser(UserModel user, int id);
    Task<bool> DeleteUser(int id);
  }
}
