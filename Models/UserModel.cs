namespace BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Models
{

  public class UserModel
  {
    public UserModel(int id, string name, string ocupation)
    {
      this.Id = id;
      this.Name = name;
      this.Ocupation = ocupation;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Ocupation { get; set; }
  }
}
