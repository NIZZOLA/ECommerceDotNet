using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class KitProductsModel
    {
        public int KitId { get; set; }
        public KitModel? Kit { get; set; }
        public int ProductId { get; set; }
        public ProductModel? Product { get; set; }
    }
}
