using LibraryApp.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Repository.Interfaces
{
    public interface IBaseRepo<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool Any(Expression<Func<T, bool>> expression);
        T GetDefault(Expression<Func<T, bool>> expression);
        IList<T> GetDefaults(Expression<Func<T, bool>> expression);
        T GetDefaultById(int id);
        List<T> OrderByASC<TKey>(Expression<Func<T, TKey>> expression);
    }
}
