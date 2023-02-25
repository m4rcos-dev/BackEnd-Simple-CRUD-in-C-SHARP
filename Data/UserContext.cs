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
      user.Property(x => x.BirthDate).HasColumnName("birth_date");
    }
  }
}
