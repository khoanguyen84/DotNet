using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopingCart.Entities
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int TotalAmount { get; set; }
        [Required]
        [Column(TypeName = "DateTime2")]
        public DateTime CreatedDate { get; set; }
        public ICollection<BillDetail> BillDetails { get; set; }
    }
}
