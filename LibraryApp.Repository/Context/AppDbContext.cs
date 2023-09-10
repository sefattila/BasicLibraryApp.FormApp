using LibraryApp.Core.Entities;
using LibraryApp.Repository.Mapping;
using LibraryApp.Repository.SeedData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Repository.Concretes
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LAUF8V8;Database=LibraryDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorMapping())
                .ApplyConfiguration(new BookMapping())
                .ApplyConfiguration(new CategoryMapping())
                .ApplyConfiguration(new UserMapping());

            modelBuilder.ApplyConfiguration(new CategorySeedData())
                .ApplyConfiguration(new BookSeedData())
                .ApplyConfiguration(new UserSeedData())
                .ApplyConfiguration(new AuthorSeedData());

            base.OnModelCreating(modelBuilder);
        }
    }
}
