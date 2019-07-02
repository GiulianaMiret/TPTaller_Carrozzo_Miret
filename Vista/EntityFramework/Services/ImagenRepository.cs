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
    /// Clase repositorio de las Imágenes, donde se va a usar el context para realizar las operaciones
    /// </summary>
    public class ImagenRepository : IRepository<Imagen>
    {
        private readonly DigitalBillboardContext _context;

        public ImagenRepository()
        {
            _context = new DigitalBillboardContext();
        }

        public IQueryable<Imagen> Get(Expression<Func<Imagen, bool>> predicate)
        {
            IQueryable<Imagen> query = _context.Imagenes.TakeWhile(predicate);
            return query;
        }

        public IEnumerable<Imagen> GetAll()
        {
            List<Imagen> listaImagenes = _context.Imagenes.ToList();
            List<Imagen> activos = new List<Imagen>();
            foreach (Imagen item in listaImagenes)
            {
                //if (item.Estado)
                //{
                //    activos.Add(item);
                //}
            }
            return activos;
        }

        public Imagen GetByName(string pNombreImagen)
        {
            Imagen mImagen = _context.Imagenes.Where(x => x.Nombre == pNombreImagen).FirstOrDefault();
            return mImagen;
        }

        public Imagen GetById(int pId)
        {
            Imagen mImagen = _context.Imagenes.Where(x => x.Id == pId).FirstOrDefault();
            return mImagen;
        }

        public Imagen GetByHash (byte[] pImagen)
        {
            Imagen mImagen = _context.Imagenes.Where(x => x.Hash == pImagen).FirstOrDefault();
            return mImagen;
        }

        public List<string> GetAllNamesFromImages()
        {
            List<string> mListasDeNombres = new List<string>();

            foreach (var item in _context.Imagenes.ToList())
            {
                mListasDeNombres.Add(item.Nombre);
            }

            return mListasDeNombres;
        }

        public void Insert(Imagen pImagen)
        {
            Imagen mBusquedaDeImagenPorHash = _context.Imagenes.Where(x => x.Hash == pImagen.Hash).FirstOrDefault();
            Imagen mBusquedaDeImagenPorNombre = _context.Imagenes.Where(x => x.Nombre == pImagen.Nombre).FirstOrDefault();
            
           _context.Imagenes.Add(pImagen);
           _context.SaveChanges();
            
        }

        public void Delete(Imagen pImagen)
        {
            Imagen mImagen = _context.Imagenes.Find(pImagen.Id);
            _context.Imagenes.Remove(mImagen);
            _context.SaveChanges();
        }

        public void DeleteByName(string pName)
        {
            Imagen mImagen = _context.Imagenes.Where(x => x.Nombre == pName).FirstOrDefault();
            _context.Imagenes.Remove(mImagen);
            _context.SaveChanges();
        }
        public void DeleteById(int pId)
        {
            Imagen mImagen = _context.Imagenes.Where(x => x.Id == pId).FirstOrDefault();
            _context.Imagenes.Remove(mImagen);
            _context.SaveChanges();
        }
        public void DeleteByHash(byte[] pHash)
        {
            Imagen mImagen = _context.Imagenes.Where(x => x.Hash == pHash).FirstOrDefault();
            //  pImagen.Estado = false;
            _context.Imagenes.Remove(mImagen);
            _context.SaveChanges();
        }
        public void Update(Imagen pImagen)
        {
            Imagen imagenAnterior = _context.Imagenes.Find(pImagen.Id);
            _context.Imagenes.Attach(pImagen);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
