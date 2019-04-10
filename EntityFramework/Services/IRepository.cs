using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace EntityFramework.Services
{
    /// <summary>
    /// Clase interfaz de los repositorios
    /// </summary>
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll();
        T GetById(int pId);
        void Insert(T entity);
        void Delete(T entity);
        void DeleteById(int pId);
        void Update(T entity);
        void Save();
    }
}
