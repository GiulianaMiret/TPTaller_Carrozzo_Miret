using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using System.Linq.Expressions;
using System.Data.Entity;
using Vista.EntityFramework.Services;

namespace EntityFramework.Services
{
    /// <summary>
    /// Clase repositorio de las Imágenes, donde se va a usar el context para realizar las operaciones
    /// </summary>
    public class ImagenRepository : IImagenRepository
    {
        private readonly DigitalBillboardContext cBillBoardContext;

        public ImagenRepository()
        {
            cBillBoardContext = new DigitalBillboardContext();
        }

        public Imagen GetByName(string pNombreImagen)
        {
            Imagen mImagen = cBillBoardContext.Imagenes.Where(x => x.Nombre == pNombreImagen).FirstOrDefault();
            if (mImagen == null)
            {
                throw new Exception("No se ha encontrado la Imagen");
            }
            return mImagen;
        }

        ///este metodo deberia eliminarse una vez que se haga el repositorio generico
        public Imagen GetById(int pId)
        {
            Imagen mImagen = cBillBoardContext.Imagenes.Where(x => x.Id == pId).FirstOrDefault();
            return mImagen;
        }

        public Imagen GetByHash (byte[] pImagen)
        {
            Imagen mImagen = cBillBoardContext.Imagenes.Where(x => x.Hash == pImagen).FirstOrDefault();
            if (mImagen == null)
            {
                throw new Exception("No se ha encontrado la Imagen");
            }
            return mImagen;
        }

        public List<string> GetAllNamesFromImages()
        {
            List<string> mListasDeNombres = new List<string>();

            foreach (var item in cBillBoardContext.Imagenes.ToList())
            {
                mListasDeNombres.Add(item.Nombre);
            }

            return mListasDeNombres;
        }

        ///este metodo deberia eliminarse una vez que se haga el repositorio generico
        public void Insert(Imagen pImagen)
        {
            Imagen mBusquedaDeImagenPorHash = cBillBoardContext.Imagenes.Where(x => x.Hash == pImagen.Hash).FirstOrDefault();
            Imagen mBusquedaDeImagenPorNombre = cBillBoardContext.Imagenes.Where(x => x.Nombre == pImagen.Nombre).FirstOrDefault();
            
            if (mBusquedaDeImagenPorHash != null)
            {
                throw new Exception("La imagen ya existe");
            }
            if (mBusquedaDeImagenPorNombre != null)
            {
                throw new Exception("Una imagen con ese nombre ya existe, elija otro.");
            }

           cBillBoardContext.Imagenes.Add(pImagen);
           cBillBoardContext.SaveChanges();
            
        }
        ///este metodo deberia eliminarse una vez que se haga el repositorio generico
        public void Delete(Imagen pImagen)
        {
            Imagen mImagen = cBillBoardContext.Imagenes.Find(pImagen.Id);
            if (mImagen == null)
            {
                throw new Exception("La Imagen no se ha encontrado");
            }
            cBillBoardContext.Imagenes.Remove(mImagen);
            cBillBoardContext.SaveChanges();
        }

        public void DeleteByName(string pName)
        {
            Imagen mImagen = cBillBoardContext.Imagenes.Where(x => x.Nombre == pName).FirstOrDefault();
            if (mImagen == null)
            {
                throw new Exception("La Imagen no se ha encontrado");
            }
            
            cBillBoardContext.Imagenes.Remove(mImagen);
            cBillBoardContext.SaveChanges();
        }
        public void DeleteById(int pId)
        {
            Imagen mImagen = cBillBoardContext.Imagenes.Where(x => x.Id == pId).FirstOrDefault();
            if (mImagen == null)
            {
                throw new Exception("La Imagen no se ha encontrado");
            }

            cBillBoardContext.Imagenes.Remove(mImagen);
            cBillBoardContext.SaveChanges();
        }
        public void DeleteByHash(byte[] pHash)
        {
            Imagen mImagen = cBillBoardContext.Imagenes.Where(x => x.Hash == pHash).FirstOrDefault();
            if (mImagen == null)
            {
                throw new Exception("La Imagen no se ha encontrado");
            }
            //  pImagen.Estado = false;
            cBillBoardContext.Imagenes.Remove(mImagen);
            cBillBoardContext.SaveChanges();
        }        
        

    }

}
