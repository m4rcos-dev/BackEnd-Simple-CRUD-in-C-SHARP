using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Models;

namespace BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Repository
{
  public interface IUserRepository
    {
      Task<IEnumerable<UserModel>> GetAllUsers();
      Task<IEnumerable<UserModel>> GetById(int id);
      void CreateUser(UserModel user);
      void UpdateUser(UserModel user);
      void DeleteUser(UserModel user);
    }
}
