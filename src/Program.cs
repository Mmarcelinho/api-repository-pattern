

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();
builder.Services.AddTransient<ICategoriesRepository, CategoriesRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Minimal API",
        Description = "Developed by Marcelo",
        Contact = new OpenApiContact { Name = "Marcelo Rosario", Email = "marcelorosario2001@gmail.com" },
        License = new OpenApiLicense { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }
    });


});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapPost("/users", async (IUserRepository userRepository, Context context, UsersInput model) =>
{

    if (!MiniValidator.TryValidate(model, out var errors))
    {
        return Results.ValidationProblem(errors);
    }

    var user = new User
    {
        Id = model.Id,
        Name = model.Name,
        Office = model.Office
    };

    userRepository.Save(user);
    var result = await context.SaveChangesAsync();

    return result > 0? Results.Created($"/Users/{user.Id}", new UsersOutput(user.Id, user.Name, user.Office)): Results.BadRequest("Houve um problema ao salvar o registro");

});



app.MapPost("/Category", async (ICategoriesRepository categoriesRepository, Context context, CategoriesInput model) =>
{

    if (!MiniValidator.TryValidate(model, out var errors))
    {
        return Results.ValidationProblem(errors);
    }

    var category = new Categories
    {
        Id = model.Id,
        Title = model.Title
    };


    categoriesRepository.Save(category);
    var result = await context.SaveChangesAsync();

     return result > 0? Results.Created($"/Category/{category.Id}", new CategoriesOutput(category.Id, category.Title)): Results.BadRequest("Houve um problema ao salvar o registro");

});

app.MapPost("/Orders", async (IOrderRepository orderRepository, Context context, ProductsInput model) =>
{

    if (!MiniValidator.TryValidate(model, out var errors)){
        return Results.ValidationProblem(errors);
    }

    var product = new Products
    {
        Id = model.Id,
        Title = model.Title,
        Price = model.Price,
        UserId = model.UserId,
        CategoryId = model.CategoriaId
    };


    orderRepository.Save(product);
    var result = await context.SaveChangesAsync();

     return result > 0? Results.Created($"/Orders/{product.Id}", new ProductsOutput(product.Id, product.Title, product.Price, product.UserId, product.CategoryId)): Results.BadRequest("Houve um problema ao salvar o registro");


});


app.Run();