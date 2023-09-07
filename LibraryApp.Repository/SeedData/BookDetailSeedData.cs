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
    public class BookDetailSeedData : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasData(
                    new BookDetail() { BookDetailId = 1, Stock = 10, Discount = 15, StockState = true },
                    new BookDetail() { BookDetailId = 2, Stock = 5, Discount = 20, StockState = true },
                    new BookDetail() { BookDetailId = 3, Stock = 11, Discount = 25, StockState = true },
                    new BookDetail() { BookDetailId = 4, Stock = 7, Discount = 0, StockState = false },
                    new BookDetail() { BookDetailId = 5, Stock = 4, Discount = 40, StockState = true }
                );
        }
    }
}
