using LibraryApp.Core.Entities;
using LibraryApp.Core.Enums;
using LibraryApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.BLL.BookService
{
    public class BookService : IBookService
    {
        private readonly IBookRepo _repo;

        public BookService(IBookRepo repo)
        {
            _repo = repo;
        }

        public bool Any(Expression<Func<Book, bool>> expression)
        {
            return _repo.Any(expression);
        }

        public void Create(Book entity)
        {
            if(entity == null)
            {
                throw new Exception("Boş Değer Eklenemez");
            }
            _repo.Create(entity);
        }

        public void Delete(Book entity)
        {
            if(entity == null)
            {
                throw new Exception("Boş Değer Silinemez");
            }
            entity.Statu = Status.Passive;
            entity.DeleteDate = DateTime.Now;
            _repo.Delete(entity);
        }

        public IList<Book> GetBooksByName(string name)
        {
            return _repo.GetBooksByName(name);
        }

        public IList<Book> GetByAuthorName(string authorName)
        {
            return _repo.GetByAuthorName(authorName);
        }

        public IList<Book> GetByCategory(string category)
        {
            return _repo.GetByCategory(category);
        }

        public Book GetDefault(Expression<Func<Book, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public Book GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public IList<Book> GetDefaults(Expression<Func<Book, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public IList<Book> GetDiscounts()
        {
            return _repo.GetDiscounts();
        }

        public IList<Book> GetLastTenBook()
        {
            return _repo.GetLastTenBook();
        }

        public IList<Book> GetStockControl()
        {
            return _repo.GetStockControl();
        }

        public List<Book> OrderByASC<TKey>(Expression<Func<Book, TKey>> expression)
        {
            return _repo.OrderByASC(expression);
        }

        public void Update(Book entity)
        {
            if (entity == null) throw new Exception("Boş Değer Güncellenemez");
            entity.UpdateDate = DateTime.Now;
            entity.Statu = Status.Modified;
            _repo.Update(entity);
        }
    }
}
