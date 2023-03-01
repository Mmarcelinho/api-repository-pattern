namespace WebApi.Models;

public class User
{

    public int Id { get; set; }

    public string Name { get; set; }

    public string Office { get; set; }

    public IList<Products>? Products { get; set; }

}
