﻿using System;
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
        private DbSet<Imagen> cDbSetImagen;

        public ImagenRepository(DigitalBillboardContext pContext)
        {
            cDbSetImagen = pContext.Set<Imagen>();
        }

        public Imagen GetByName(string pNombreImagen)
        {
            Imagen mImagen = cDbSetImagen.Where(x => x.Nombre == pNombreImagen).FirstOrDefault();
            if (mImagen == null)
            {
                throw new Exception("No se ha encontrado la Imagen");
            }
            return mImagen;
        }

        public Imagen GetByHash (byte[] pImagen)
        {
            Imagen mImagen = cDbSetImagen.Where(x => x.Hash == pImagen).FirstOrDefault();
            if (mImagen == null)
            {
                throw new Exception("No se ha encontrado la Imagen");
            }
            return mImagen;
        }

        public List<string> GetAllNamesFromImages()
        {
            List<string> mListasDeNombres = new List<string>();

            foreach (var item in cDbSetImagen.ToList())
            {
                mListasDeNombres.Add(item.Nombre);
            }

            return mListasDeNombres;
        }

        public void DeleteByName(string pName)
        {
            Imagen mImagen = cDbSetImagen.Where(x => x.Nombre == pName).FirstOrDefault();
            if (mImagen == null)
            {
                throw new Exception("La Imagen no se ha encontrado");
            }
            
            cDbSetImagen.Remove(mImagen);
        }

        public void DeleteByHash(byte[] pHash)
        {
            Imagen mImagen = cDbSetImagen.Where(x => x.Hash == pHash).FirstOrDefault();
            if (mImagen == null)
            {
                throw new Exception("La Imagen no se ha encontrado");
            }
            
            cDbSetImagen.Remove(mImagen);            
        }        
        

    }

}
