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
    public class ImagenRepository : IRepository<Imagen>
    {
        private readonly DigitalBillboardContext _context;

        public ImagenRepository(DigitalBillboardContext context)
        {
            _context = context;
        }

        //IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        public IQueryable<Imagen> Find(Expression<Func<Imagen, bool>> predicate)
        {
            IQueryable<Imagen> query = _context.Set<Imagen>().Where(predicate);
            return query;
        }

        //IEnumerable<T> GetAll();
        public IEnumerable<Imagen> GetAll()
        {
            return _context.Imagenes.ToList();
        }

        //T GetById(int pId);
        public Imagen GetById(int pId)
        {
            return _context.Imagenes.Find(pId);
        }

        //void Insert(T entity);
        public void Insert(Imagen pImagen)
        {
            _context.Imagenes.Add(pImagen);
        }

        //void Delete(T entity);
        public void Delete(Imagen pImagen)
        {
            _context.Imagenes.Remove(pImagen);
        }

        //void DeleteById(int pId);
        public void DeleteById(int pId)
        {
            Imagen pImagen = _context.Imagenes.Find(pId);
            _context.Imagenes.Remove(pImagen);
        }

        //void Update(T entity);
        public void Update(Imagen pImagen)
        {
            _context.Entry(pImagen).State = EntityState.Modified;
        }

        //void Save();
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
