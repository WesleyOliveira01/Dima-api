using System.ComponentModel.DataAnnotations;

namespace Dima.core.Requests.Categories;

public class DeleteCategoryRequest : Request
{
    [Required(ErrorMessage = "Id invalido")]
    public long Id { get; set; }
}
