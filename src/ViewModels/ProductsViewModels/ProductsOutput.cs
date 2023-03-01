namespace WebApi.ViewModels.ProductsViewModels;

public class ProductsOutput
{
    public ProductsOutput(int id, string title, decimal price, int categoriaId, int userId)
    {
        this.Id = id;
        this.Title = title;
        this.Price = price;
        this.CategoriaId = categoriaId;
        this.UserId = userId;

    }
    public int Id { get; set; }

    public string Title { get; private set; }

    public decimal Price { get; set; }

    public int CategoriaId { get; set; }

    public int UserId { get; set; }
}
