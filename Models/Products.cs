using System.ComponentModel.DataAnnotations;

namespace LeahSporting.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Please enter a name for the product.")]
        public string? Name { get; set; }
  
        [Required(ErrorMessage = "Please enter a category for the product.")]
        public string? Category { get; set; }

        [Required(ErrorMessage = "Please enter a size for the product.")]
        [Range(0, 26, ErrorMessage = "Sizes are between 0 and 26.")]
        public int? Size { get; set; }

        [Required(ErrorMessage = "Please enter a privce for the product.")]
        public decimal? Price { get; set; }



    }
}
