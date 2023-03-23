using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StaffAPI.Entities
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string GroupName { get; set; }
    }
}
