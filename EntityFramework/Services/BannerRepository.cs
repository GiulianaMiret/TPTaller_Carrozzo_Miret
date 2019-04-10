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
    /// <summary>
    /// Clase repositorio del banner, donde se va a usar el context para realizar las operaciones
    /// </summary>
    public class BannerRepository : IRepository<Banner>
    {
        private readonly DigitalBillboardContext _context;

        public BannerRepository(DigitalBillboardContext context)
        {
            _context = context;
        }

        //IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        public IQueryable<Banner> Find(Expression<Func<Banner, bool>> predicate)
        {
            IQueryable<Banner> query = _context.Set<Banner>().Where(predicate);
            return query;
        }

        //IEnumerable<T> GetAll();
        public IEnumerable<Banner> GetAll()
        {
            return _context.Banners.ToList();
        }

        //T GetById(int pId);
        public Banner GetById(int pId)
        {
            return _context.Banners.Find(pId);
        }

        //void Insert(T entity);
        public void Insert(Banner pBanner)
        {
            _context.Banners.Add(pBanner);
        }

        //void Delete(T entity);
        public void Delete(Banner pBanner)
        {
            _context.Banners.Remove(pBanner);
        }

        //void DeleteById(int pId);
        public void DeleteById(int pId)
        {
            Banner pBanner = _context.Banners.Find(pId);
            _context.Banners.Remove(pBanner);
        }

        //void Update(T entity);
        public void Update(Banner pBanner)
        {
            _context.Entry(pBanner).State = EntityState.Modified;
        }

        //void Save();
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
