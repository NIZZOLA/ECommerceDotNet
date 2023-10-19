using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    [Table("Brands")]
    public class BrandModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public bool IsActive { get; set; }

        public ICollection<ProductModel> Products { get; set; }
    }
}
