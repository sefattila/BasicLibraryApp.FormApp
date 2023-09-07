using LibraryApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Repository.Mapping
{
    public class BookDetailMapping : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.Property(x => x.Stock)
                .HasColumnType("int");

            builder.HasOne(x => x.Book)
                .WithOne(x=>x.BookDetail)
                .HasForeignKey<BookDetail>(x =>x.BookDetailId);
        }
    }
}
