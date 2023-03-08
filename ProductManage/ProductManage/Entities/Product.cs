using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManage.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(maximumLength:50, MinimumLength = 2)]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 200, MinimumLength = 2)]
        [Column(TypeName = "nvarchar(200)")]
        public string Description { get; set; }
        [Required]
        [Range(minimum: 0, maximum:int.MaxValue)]
        public double Price { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Rates { get; set; }
    }
}
