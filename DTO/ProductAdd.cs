using ShoppingCartDataAccess.DBEntities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCartMonolithApplication.DTO
{
    public class ProductAdd
    {
        [StringLength(100)]
        [Required]
        public string ProductName { get; set; } = string.Empty;

        [StringLength(2000)]
        public string? ProductDescription { get; set; } = string.Empty;

        [Required]
        public int ProductCategoryId { get; set; }

        [Required]
        public double ProductPrice { get; set; }

        public double? ProductDiscount { get; set; }

    }
}
