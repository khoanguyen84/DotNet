using Microsoft.EntityFrameworkCore;
using ShopingCart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.AppContext
{
    public class ShoppingContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=khoanguyen\sqlexpress;Initial Catalog=ShoppingDb;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    ProductName = "iPhone 13 Pro Max",
                    Price = 15000000,
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "iPhone 14 Pro Max",
                    Price = 25000000,
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "iPhone X",
                    Price = 7000000,
                },
                new Product()
                {
                    ProductId = 4,
                    ProductName = "iPhone 11 Pro Max",
                    Price = 12000000,
                }
            );
        }
    }
}
