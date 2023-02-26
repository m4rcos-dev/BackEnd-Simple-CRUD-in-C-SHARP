using BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Data
{
  public class UserContext : DbContext
  {
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {
    }

    public DbSet<UserModel> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      var user = modelBuilder.Entity<UserModel>();
      user.ToTable("tb_users");
      user.HasKey(x => x.Id);
      user.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
      user.Property(x => x.Name).HasColumnName("name").IsRequired();
      user.Property(x => x.Ocupation).HasColumnName("ocupation");

      user.HasData(new List<UserModel> {
        new UserModel(1, "Gabrielle Pereira", "Terapeuta respiratório registrado"),
        new UserModel(2, "Emily Gonçalves", "funcionária do correio"),
        new UserModel(3, "Lavínia Pereira", "enfermeira do hospício"),
        new UserModel(4, "Raissa Alves", "diretora de tecnologia"),
        new UserModel(5, "Isabelle Cardoso", "Técnico de pré-impressão eletrônica"),
        new UserModel(6, "Fernanda Castro", "Mecânica de veículos pesados e equipamentos móveis"),
        new UserModel(7, "Matheus Goncalves", "terapeuta de radiação"),
        new UserModel(8, "Kauan Correia", "Instalador de aquecimento, ar condicionado e refrigeração"),
        new UserModel(9, "Otávio Carvalho", "Trabalhador de navio de cruzeiro"),
        new UserModel(10, "Carlos Ferreira", "Assistente médico"),
      });
    }
  }
}
