using LibraryApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.BLL.BookService
{
    public interface IBookService
    {
        void Create(Book entity);
        void Update(Book entity);
        void Delete(Book entity);
        bool Any(Expression<Func<Book, bool>> expression);
        Book GetDefault(Expression<Func<Book, bool>> expression);
        IList<Book> GetDefaults(Expression<Func<Book, bool>> expression);
        Book GetDefaultById(int id);
        List<Book> OrderByASC<TKey>(Expression<Func<Book, TKey>> expression);
        //...


        IList<Book> GetBooksByName(string name);
        IList<Book> GetByCategory(string category);
        IList<Book> GetByAuthorName(string authorName);
        IList<Book> GetDiscounts();
        IList<Book> GetStockControl();
        IList<Book> GetLastTenBook();
    }
}
