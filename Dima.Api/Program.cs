using Dima.Api.Data;
using Dima.core.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.CustomSchemaIds(n => n.FullName);
});

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/v1/category", () => "Create : category")
    .WithSummary("Create : category")
    .WithDescription("Cria uma nova categoria")
    .Produces<string>();

app.Run();
