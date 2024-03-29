﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductManage.AppContext;

#nullable disable

namespace ProductManage.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20230309071737_Create_Relationship_Category_Product")]
    partial class Create_Relationship_Category_Product
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProductManage.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Mobile"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Laptop"
                        });
                });

            modelBuilder.Entity("ProductManage.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Rates")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "iPhone 13 Pro Max, Manufactory Thailand",
                            Name = "iPhone 13 Pro Max",
                            Price = 20000000.0,
                            Rates = ""
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "iPhone 14 Pro Max, Manufactory Thailand",
                            Name = "iPhone 14 Pro Max",
                            Price = 30000000.0,
                            Rates = ""
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Description = "iPhone X, Manufactory Thailand",
                            Name = "iPhone X",
                            Price = 4000000.0,
                            Rates = ""
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            Description = "iPhone 11, Manufactory Thailand",
                            Name = "iPhone 11",
                            Price = 10000000.0,
                            Rates = ""
                        });
                });

            modelBuilder.Entity("ProductManage.Entities.Product", b =>
                {
                    b.HasOne("ProductManage.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ProductManage.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
