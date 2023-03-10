using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopingCart.Entities
{
    public class BillDetail
    {
        [Key]
        public int BillDetailId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Price { get; set; }
        [Required]
        [Range(0, 100)]
        public int Quantity { get; set; }
        public int Amount => Price * Quantity;
        [ForeignKey(nameof(Bill))]
        public int BillId { get; set; }
        public Bill Bill { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
