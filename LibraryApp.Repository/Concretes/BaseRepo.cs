using LibraryApp.Core.Abstract;
using LibraryApp.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Repository.Concretes
{
    public class BaseRepo<T> : IBaseRepo<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _table;

        public BaseRepo(AppDbContext context)
        {
            this._context = context;
            this._table=context.Set<T>();
        }


        public bool Any(Expression<Func<T, bool>> expression)
        {
            return _table.Any(expression);
        }

        public void Create(T entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.SaveChanges();
        }

        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            return _table.FirstOrDefault(expression);
        }

        public T GetDefaultById(int id)
        {
            return _table.Find(id);
        }

        public IList<T> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }

        public List<T> OrderByASC<TKey>(Expression<Func<T, TKey>> expression)
        {
            return _table.OrderBy(expression).ToList();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State= EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
