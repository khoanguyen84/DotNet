﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StaffAPI.StaffContext;

#nullable disable

namespace StaffAPI.Migrations
{
    [DbContext(typeof(StaffDbContext))]
    [Migration("20230323074036_CreateStaffDb")]
    partial class CreateStaffDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StaffAPI.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GroupName = "Industrial"
                        },
                        new
                        {
                            Id = 2,
                            GroupName = "Games"
                        });
                });

            modelBuilder.Entity("StaffAPI.Entities.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avatar = "http://res.cloudinary.com/dtxyz2s1g/image/upload/v1665451443/papvmvvxex07khf2ntmk.jpg",
                            Company = "Walker Morrow LLC",
                            Email = "raduhopir@mailinator.com",
                            GroupId = 1,
                            Mobile = "+1 (527) 129-3735",
                            Name = "Arden Grant",
                            Title = "Tempora adipisci sin"
                        },
                        new
                        {
                            Id = 2,
                            Avatar = "http://res.cloudinary.com/dtxyz2s1g/image/upload/v1664334766/mdmzrzvbnw56tx24jyj2.jpg",
                            Company = "Kunde and Sons",
                            Email = "Carol_Hegmann@gmail.com",
                            GroupId = 2,
                            Mobile = "651-903-2931",
                            Name = "Kling",
                            Title = "Dynamic Integration Assistant"
                        });
                });

            modelBuilder.Entity("StaffAPI.Entities.Staff", b =>
                {
                    b.HasOne("StaffAPI.Entities.Group", "Group")
                        .WithMany("Staffs")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("StaffAPI.Entities.Group", b =>
                {
                    b.Navigation("Staffs");
                });
#pragma warning restore 612, 618
        }
    }
}
