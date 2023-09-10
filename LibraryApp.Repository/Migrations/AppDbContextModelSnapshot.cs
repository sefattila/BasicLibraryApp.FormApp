﻿// <auto-generated />
using System;
using LibraryApp.Repository.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryApp.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LibraryApp.Core.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Surname");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5494),
                            FirstName = "Sefa",
                            LastName = "Attila",
                            Statu = 0
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5495),
                            FirstName = "Peyami",
                            LastName = "Safa",
                            Statu = 0
                        });
                });

            modelBuilder.Entity("LibraryApp.Core.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<bool>("StockState")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            BookName = "Attila",
                            CategoryId = 3,
                            CreateDate = new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5364),
                            Discount = 15.0,
                            Fiyat = 120.0,
                            ReleaseDate = new DateTime(1998, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Statu = 0,
                            Stock = 10,
                            StockState = true
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            BookName = "Deneme",
                            CategoryId = 1,
                            CreateDate = new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5370),
                            Discount = 20.0,
                            Fiyat = 69.0,
                            ReleaseDate = new DateTime(2000, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Statu = 0,
                            Stock = 5,
                            StockState = true
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            BookName = "Deneme1",
                            CategoryId = 2,
                            CreateDate = new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5372),
                            Discount = 25.0,
                            Fiyat = 136.0,
                            ReleaseDate = new DateTime(2010, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Statu = 0,
                            Stock = 11,
                            StockState = true
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            BookName = "Deneme2",
                            CategoryId = 1,
                            CreateDate = new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5373),
                            Discount = 0.0,
                            Fiyat = 75.0,
                            ReleaseDate = new DateTime(2009, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Statu = 0,
                            Stock = 7,
                            StockState = false
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 1,
                            BookName = "Deneme3",
                            CategoryId = 3,
                            CreateDate = new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5374),
                            Discount = 40.0,
                            Fiyat = 225.0,
                            ReleaseDate = new DateTime(1071, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Statu = 0,
                            Stock = 4,
                            StockState = true
                        });
                });

            modelBuilder.Entity("LibraryApp.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryName")
                        .IsUnique();

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Roman",
                            CreateDate = new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5199),
                            Statu = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Karikatür",
                            CreateDate = new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5212),
                            Statu = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Tarih",
                            CreateDate = new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5212),
                            Statu = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Biyografi",
                            CreateDate = new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5213),
                            Statu = 0
                        });
                });

            modelBuilder.Entity("LibraryApp.Core.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5437),
                            Email = "attila@gmail.com",
                            FirstName = "Sefa",
                            LastName = "Attila",
                            Password = "123456",
                            Statu = 0
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5439),
                            Email = "ali@gmail.com",
                            FirstName = "Ali",
                            LastName = "Yaşar",
                            Password = "54546546",
                            Statu = 0
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5441),
                            Email = "mehmet@gmail.com",
                            FirstName = "Mehmet",
                            LastName = "Gündüz",
                            Password = "873687",
                            Statu = 0
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5441),
                            Email = "mahmut@gmail.com",
                            FirstName = "Mahmut",
                            LastName = "Gece",
                            Password = "981376",
                            Statu = 0
                        });
                });

            modelBuilder.Entity("LibraryApp.Core.Entities.Book", b =>
                {
                    b.HasOne("LibraryApp.Core.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryApp.Core.Entities.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("LibraryApp.Core.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LibraryApp.Core.Entities.Category", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
