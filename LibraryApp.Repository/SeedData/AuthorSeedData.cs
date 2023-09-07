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
    public class AuthorSeedData : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(
                    new Author() { Id = 1, FirstName = "Sefa", LastName = "Attila" },
                    new Author() { Id = 2, FirstName = "Peyami", LastName = "Safa" }
                );
        }
    }
}
