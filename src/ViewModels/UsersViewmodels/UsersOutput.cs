namespace WebApi.ViewModels.UsersViewmodels;

public class UsersOutput
{

    public UsersOutput(int id, string name, string office)
    {
        this.Id = id;
        this.Name = name;
        this.Office = office;

    }
    public int Id { get; set; }


    public string Name { get; set; }


    public string Office { get; set; }

}
