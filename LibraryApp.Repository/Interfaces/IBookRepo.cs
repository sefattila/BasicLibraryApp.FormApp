using LibraryApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Repository.Interfaces
{
    public interface IBookRepo : IBaseRepo<Book>
    {
        IList<Book> GetBooksByName(string name);
        IList<Book> GetByCategory(string category);
        IList<Book> GetByAuthorName(string authorName);
        IList<Book> GetDiscounts();
        IList<Book> GetStockControl();
        IList<Book> GetLastTenBook();
    }
}
