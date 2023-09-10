using LibraryApp.Core.Entities;
using LibraryApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Repository.Concretes
{
    public class BookRepo : BaseRepo<Book>, IBookRepo
    {
        private readonly AppDbContext _context;
        public BookRepo(AppDbContext context) : base(context)
        {
            this._context = context;
        }

        public IList<Book> GetBooksByName(string name)
        {
            return _context.Books.Where(x=>x.BookName.Contains(name)).OrderByDescending(x=>x.CreateDate).ToList();
        }

        public IList<Book> GetByAuthorName(string authorName)
        {
            return _context.Books.Where(x=>x.Author.FirstName.Contains(authorName)).OrderBy(x=>x.ReleaseDate).ToList();
        }

        public IList<Book> GetByCategory(string category)
        {
            return _context.Books.Where(x=>x.Category.CategoryName.Contains(category)).OrderBy(x=>x.BookName).ToList();
        }

        public IList<Book> GetDiscounts()
        {
            return _context.Books.Where(x => x.Discount > 0).OrderByDescending(x => x.Discount).ToList();
        }

        public IList<Book> GetLastTenBook()
        {
            return _context.Books.OrderBy(x => x.CreateDate).Take(10).ToList();
        }

        public IList<Book> GetStockControl()
        {
            return _context.Books.Where(x => x.Stock < 10).ToList();
        }
    }
}
