using EComerce;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//* Add services to the container.

// BD
var dbConectionString = builder.Configuration.GetConnectionString("ConexionSql");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(dbConectionString));

// Repositories
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

// Mappers
builder.Services.AddAutoMapper(config =>
{
    config.AddProfile<CategoryProfile>();
});

// Controllers
builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
