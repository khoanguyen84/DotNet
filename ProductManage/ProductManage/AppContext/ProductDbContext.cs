using Microsoft.EntityFrameworkCore;
using ProductManage.Entities;

namespace ProductManage.AppContext
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=khoanguyen\sqlexpress;Initial Catalog=CGCafe;Integrated Security=True; Encrypt=True; TrustServerCertificate=True");
        }

        //Seeding data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Mobile",
                },
                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "Laptop",
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    Description = "iPhone 13 Pro Max, Manufactory Thailand",
                    Name = "iPhone 13 Pro Max",
                    Price = 20000000,
                    Rates = "",
                    CategoryId = 1
                },
                new Product()
                {
                    ProductId = 2,
                    Description = "iPhone 14 Pro Max, Manufactory Thailand",
                    Name = "iPhone 14 Pro Max",
                    Price = 30000000,
                    Rates = "",
                    CategoryId = 1
                },
                new Product()
                {
                    ProductId = 3,
                    Description = "iPhone X, Manufactory Thailand",
                    Name = "iPhone X",
                    Price = 4000000,
                    Rates = "",
                    CategoryId = 1
                },
                new Product()
                {
                    ProductId = 4,
                    Description = "iPhone 11, Manufactory Thailand",
                    Name = "iPhone 11",
                    Price = 10000000,
                    Rates = "",
                    CategoryId = 1
                }
           );
            modelBuilder.Entity<Staff>().HasData(
                new Staff()
                {
                    StaffId = 1,
                    DateOfBirth = DateTime.Now,
                    Email = "khoa.nguyen@codegym.vn",
                    Fullname = "Khoa Nguyễn"
                },
                new Staff()
                {
                    StaffId = 2,
                    DateOfBirth = DateTime.Now,
                    Email = "quang.dang@codegym.vn",
                    Fullname = "Quang Đặng"
                }
            );
        }
    }
}
