namespace WebApi.Repositories;
public class UserRepository : IUserRepository
{

    private readonly Context _context;
    public UserRepository(Context context)
    {

        _context = context;

    }
    public void Save(User user)
    {
        _context.Users.Add(user);
    }

}

