using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopingCart.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = ("nvarchar(50)"))]
        public string ProductName { get; set; }
        [Required]
        [Range(minimum:0, maximum:int.MaxValue)]
        public int Price { get; set; }
    }
}
