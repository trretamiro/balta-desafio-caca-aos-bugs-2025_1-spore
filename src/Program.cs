using BugStore.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var confString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(confString));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
