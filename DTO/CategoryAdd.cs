using System.ComponentModel.DataAnnotations;

namespace ShoppingCartMonolithApplication.DTO
{
    public class CategoryAdd
    {
        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }
    }
}









