namespace WebApi.Models;

public class Products
{

  
    public int Id { get; set; }

    public string Title { get; set; }

    public decimal Price { get; set; }

    public int CategoryId { get; set; }

    public int UserId { get; set; }

    public User user { get; set; } = null!;

    public Categories category { get; set; } = null!;


}
