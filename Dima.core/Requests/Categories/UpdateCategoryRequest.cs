using System.ComponentModel.DataAnnotations;

namespace Dima.core.Requests.Categories;

public class UpdateCategoryRequest : CreateCategoryRequest
{
    [Required(ErrorMessage = "Id invalido")]
    public long Id { get; set; }
}
