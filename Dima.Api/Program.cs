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
builder.Services.AddTransient<Handler>();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/v1/category", (Request request, Handler handler) => handler.Handle(request))
    .WithSummary("Create : category")
    .WithDescription("Cria uma nova categoria")
    .Produces<Response>();

app.Run();

public class Request(string Titulo, string? Description)
{
    public string Titulo { get; set; } = Titulo;
    public string? Description { get; set; } = Description;
}

public class Response(long Id, string Titulo)
{
    public long Id { get; set; } = Id;
    public string Titulo { get; set; } = Titulo;
}

public class Handler(AppDbContext context)
{
    public Response Handle(Request request)
    {
        Category category = new Category
        {
            Titulo = request.Titulo,
            Description = request.Description
        };
        context.Categories.Add(category);
        context.SaveChanges();
        return new Response(category.Id, category.Titulo);
    }
}
