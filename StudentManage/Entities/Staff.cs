using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage.Entities
{
    internal class Staff
    {
        [Key]
        public int StaffId { get; set; }
        [Required]
        [StringLength(maximumLength:50, MinimumLength = 10)]
        [Column(TypeName ="nvarchar(50)")]
        public string Fullname { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
