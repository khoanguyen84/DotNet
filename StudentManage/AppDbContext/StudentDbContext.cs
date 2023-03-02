
using Microsoft.EntityFrameworkCore;
using StudentManage.Entities;

namespace StudentManage.AppDbContext
{
    internal class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Staff> Staffs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=khoanguyen\sqlexpress;Initial Catalog=StudentDb;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Staff>().HasData(
                new Staff()
                {
                    StaffId = 1,
                    Fullname = "Khoa Nguyễn",
                    DateOfBirth = DateTime.Parse("10/10/2000")
                },
                new Staff()
                {
                    StaffId = 2,
                    Fullname = "Quang Đặng",
                    DateOfBirth = DateTime.Parse("09/09/2000")
                }
             );
        }
    }
}
