namespace WebApi.Repositories;

public class OrderRepository : IOrderRepository
{

    private readonly Context _context;
    public OrderRepository(Context context)
    {

        _context = context;

    }
    public void Save(Products products)
    {
        _context.Products.Add(products);

    }


}

