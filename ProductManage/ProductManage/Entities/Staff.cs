using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManage.Entities
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Fullname { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
    }
}
