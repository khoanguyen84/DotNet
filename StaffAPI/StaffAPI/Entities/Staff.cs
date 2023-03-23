using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StaffAPI.Entities
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        [Column(TypeName = "nvarchar(20)")]
        public string Mobile { get; set; }
        [Required]
        [StringLength(int.MaxValue)]
        [Column(TypeName = "nvarchar(max)")]
        public string Avatar { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Company { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }
        [ForeignKey("GroupId")]
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
