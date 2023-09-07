using LibraryApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Repository.SeedData
{
    public class CategorySeedData : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                    new Category() { Id = 1, CategoryName = "Roman" },
                    new Category() { Id = 2, CategoryName = "Karikatür" },
                    new Category() { Id = 3, CategoryName = "Tarih" },
                    new Category() { Id = 4, CategoryName = "Biyografi" }
                );
        }
    }
}
