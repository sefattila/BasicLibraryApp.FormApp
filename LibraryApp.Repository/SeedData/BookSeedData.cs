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
    public class BookSeedData : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                    new Book() { Id = 1, BookName = "Attila", Fiyat = 120, AuthorId = 1, ReleaseDate = new DateTime(1998, 09, 25) },
                    new Book() { Id = 2, BookName = "Deneme", Fiyat = 69, AuthorId = 2, ReleaseDate = new DateTime(2000, 04, 20) },
                    new Book() { Id = 3, BookName = "Deneme1", Fiyat = 136, AuthorId = 1, ReleaseDate = new DateTime(2010, 11, 25) },
                    new Book() { Id = 4, BookName = "Deneme2", Fiyat = 75, AuthorId = 2, ReleaseDate = new DateTime(2009, 01, 20) },
                    new Book() { Id = 5, BookName = "Deneme3", Fiyat = 225, AuthorId = 1, , ReleaseDate = new DateTime(1071, 09, 25) }
                );
        }
    }
}
