using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using System.Linq.Expressions;
using System.Data.Entity;

namespace EntityFramework.Services
{
    public class FuenteRepository : IRepository<Fuente>
    {
        private readonly DigitalBillboardContext _context;

        public FuenteRepository(DigitalBillboardContext context)
        {
            _context = context;
        }

        //IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        public IQueryable<Fuente> Find(Expression<Func<Fuente, bool>> predicate)
        {
            IQueryable<Fuente> query = _context.Set<Fuente>().Where(predicate);
            return query;
        }

        //IEnumerable<T> GetAll();
        public IEnumerable<Fuente> GetAll()
        {
            return _context.Fuentes.ToList();
        }

        //T GetById(int pId);
        public Fuente GetById(int pId)
        {
            return _context.Fuentes.Find(pId);
        }

        //void Insert(T entity);
        public void Insert(Fuente pFuente)
        {
            _context.Fuentes.Add(pFuente);
        }

        //void Delete(T entity);
        public void Delete(Fuente pFuente)
        {
            _context.Fuentes.Remove(pFuente);
        }

        //void DeleteById(int pId);
        public void DeleteById(int pId)
        {
            Fuente fuente = _context.Fuentes.Find(pId);
            _context.Fuentes.Remove(fuente);
        }

        //void Update(T entity);
        public void Update(Fuente pFuente)
        {
            _context.Entry(pFuente).State = EntityState.Modified;
        }

        //void Save();
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
