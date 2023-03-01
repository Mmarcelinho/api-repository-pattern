namespace WebApi.Repositories;

public class CategoriesRepository : ICategoriesRepository
{
    private readonly Context _context;
    public CategoriesRepository(Context context)
    {
        _context = context;
    }
    public void Save(Categories categories)
    {
        _context.Categories.Add(categories);
    }

  
}
