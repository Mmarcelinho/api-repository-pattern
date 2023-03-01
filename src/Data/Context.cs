namespace WebApi.Data;

public class Context : DbContext
{

    public Context(DbContextOptions<Context> options) : base(options)
    { }

    public DbSet<User> Users { get; set; }

    public DbSet<Categories> Categories { get; set; }

    public DbSet<Products> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<User>()
        .HasKey(x => x.Id);

        modelBuilder.Entity<User>()
        .Property(x => x.Name)
        .IsRequired()
        .HasColumnType("varchar(50)");

        modelBuilder.Entity<User>()
        .Property(x => x.Office)
        .IsRequired()
        .HasColumnType("varchar(50)");

        modelBuilder.Entity<Categories>()
        .HasKey(x => x.Id);

        modelBuilder.Entity<Categories>()
        .Property(x => x.Title)
        .IsRequired()
        .HasColumnType("varchar(100)");

        modelBuilder.Entity<Products>()
        .HasKey(x => x.Id);

        modelBuilder.Entity<Products>()
        .Property(x => x.Title)
        .IsRequired()
        .HasColumnType("varchar(100)");

        modelBuilder.Entity<Products>()
        .Property(x => x.Price)
        .IsRequired()
        .HasColumnType("numeric(38,2)");

        modelBuilder.Entity<Products>().
        HasOne(x => x.user)
        .WithMany(x => x.Products)
        .HasForeignKey(x => x.UserId)
        .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Products>()
        .HasOne(x => x.category)
        .WithMany(x => x.Products)
        .HasForeignKey(x => x.CategoryId)
        .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<User>().ToTable("User");
        modelBuilder.Entity<Categories>().ToTable("Category");
        modelBuilder.Entity<Products>().ToTable("Products");
        
        base.OnModelCreating(modelBuilder);

    }

}
