using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Data
{
  public class UsuarioContext : DbContext
  {
    public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
    {
    }

    public DbSet<UsuarioModel> Usuarios {get; set;}
  }
}
