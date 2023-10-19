using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    [Table("Products")]
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set;}
        public decimal PriceWithDiscount { get; set;}
        public decimal Weight { get; set;}
        public decimal Stock { get; set;}
        public string Picture { get; set;}

        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public BrandModel? Brand { get; set; }
        
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public CategoryModel? Category { get; set; }
    }
}
