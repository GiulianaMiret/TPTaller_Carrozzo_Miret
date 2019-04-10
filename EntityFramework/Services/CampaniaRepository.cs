using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using System.Linq.Expressions;
using System.Data.Entity;

namespace EntityFramework.Services
{
    public class CampaniaRepository : IRepository<Campania>
    {
        private readonly DigitalBillboardContext _context;
        
        public CampaniaRepository(DigitalBillboardContext context)
        {
            _context = context;
        }


        //IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        public IQueryable<Campania> Find(Expression<Func<Campania, bool>> predicate)
        {
            IQueryable<Campania> query = _context.Set<Campania>().Where(predicate);
            return query;
        }

        //IEnumerable<T> GetAll();
        public IEnumerable<Campania> GetAll()
        {
            return _context.Campanias.ToList();
        }

        //T GetById(int pId);
        public Campania GetById(int pId)
        {
            return _context.Campanias.Find(pId);
        }

        //void Insert(T entity);
        public void Insert(Campania pCampania)
        {
            try
            {
                //agrega la entidad al contexto:
                _context.Campanias.Add(pCampania);
                //se inserta en la DB:
                //_context.SaveChanges();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        //void Delete(T entity);
        public void Delete(Campania pCampania)
        {
            _context.Campanias.Remove(pCampania);
        }

        //void DeleteById(int pId);
        public void DeleteById(int pId)
        {
            Campania campania = _context.Campanias.Find(pId);
            _context.Campanias.Remove(campania);
        }

        //void Update(T entity);
        public void Update(Campania pCampania)
        {
            _context.Entry(pCampania).State = EntityState.Modified;
        }

        //void Save();
        public void Save()
        {
            _context.SaveChanges();
        }

        //ESTO ES PORQUE USA IDISPOSABLE
        //private bool disposed = false;

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            _context.Dispose();
        //        }
        //    }
        //    this.disposed.true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
    }
}
