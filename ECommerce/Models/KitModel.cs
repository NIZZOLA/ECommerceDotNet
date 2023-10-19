using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class KitModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PriceWithDiscount { get; set; }

        public ICollection<KitProductsModel> KitProducts { get; set; }
    }
}
