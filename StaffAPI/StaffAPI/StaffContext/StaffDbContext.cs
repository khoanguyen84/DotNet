using Microsoft.EntityFrameworkCore;
using StaffAPI.Entities;

namespace StaffAPI.StaffContext
{
    public class StaffDbContext : DbContext
    {
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=khoanguyen\sqlexpress;Initial Catalog=StaffDb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().HasData(
                new Group()
                {
                    GroupName = "Industrial",
                    Id = 1
                },
                new Group()
                {
                    GroupName = "Games",
                    Id = 2
                },
                new Group()
                {
                    GroupName = "Beauty",
                    Id = 3
                },
                new Group()
                {
                    GroupName = "Automotive",
                    Id = 4
                },
                new Group()
                {
                    GroupName = "Garden",
                    Id = 5
                }
            );
            modelBuilder.Entity<Staff>().HasData(
                new Staff()
                {
                    Name = "Arden Grant",
                    Mobile = "+1 (527) 129-3735",
                    Avatar = "http://res.cloudinary.com/dtxyz2s1g/image/upload/v1665451443/papvmvvxex07khf2ntmk.jpg",
                    Email = "raduhopir@mailinator.com",
                    Company = "Walker Morrow LLC",
                    Title = "Tempora adipisci sin",
                    Id = 1,
                    GroupId = 1
                },
                new Staff()
                {
                    Name = "Kling",
                    Mobile = "651-903-2931",
                    Avatar = "http://res.cloudinary.com/dtxyz2s1g/image/upload/v1664334766/mdmzrzvbnw56tx24jyj2.jpg",
                    Email =  "Carol_Hegmann@gmail.com",
                    Company =  "Kunde and Sons",
                    Title =  "Dynamic Integration Assistant",
                    GroupId = 2,
                    Id = 2
                }
            );
        }
    }
}
