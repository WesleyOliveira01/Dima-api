using System.ComponentModel.DataAnnotations;

namespace Dima.core.Requests.Categories;

public class CreateCategoryRequest : Request
{
    [Required(ErrorMessage = "Titulo invalido")]
    [MaxLength(80, ErrorMessage = "Titulo deve ter no máximo 80 caracteres")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Descrição invalida")]
    public string Description { get; set; } = string.Empty;
}
