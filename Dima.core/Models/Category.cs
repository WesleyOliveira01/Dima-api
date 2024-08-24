namespace Dima.core.Models;

public class Category { 
    public long Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string? Descripcion { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;
}
