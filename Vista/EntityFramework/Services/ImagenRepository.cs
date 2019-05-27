﻿using System;
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
            if (query.Count() == 0)
            {
                throw new Exception("No hay Imagenes");
            }
            return query;
        }

        public IEnumerable<Imagen> GetAll()
        {
            List<Imagen> listaImagenes = _context.Imagenes.ToList();
            List<Imagen> activos = new List<Imagen>();
            foreach (Imagen item in listaImagenes)
            {
                if (item.Estado)
                {
                    activos.Add(item);
                }
            }
            if (activos.Count() == 0)
            {
                throw new Exception("No hay Imagenes");
            }
            return activos;
        }

        public Imagen GetByName(string pNombreImagen)
        {
            Imagen mImagen = _context.Imagenes.Where(x => x.Nombre == pNombreImagen).FirstOrDefault();
            if ((mImagen == null) || !(mImagen.Estado))
            {
                throw new Exception("No se ha encontrado la Imagen");
            }
            return mImagen;
        }

        public Imagen GetById(int pId)
        {
            Imagen mImagen = _context.Imagenes.Where(x => x.Id == pId).FirstOrDefault();
            if ((mImagen == null) || !(mImagen.Estado))
            {
                throw new Exception("No se ha encontrado la Imagen");
            }
            return mImagen;
        }

        public Imagen GetByHash (byte[] pImagen)
        {
            Imagen mImagen = _context.Imagenes.Where(x => x.Hash == pImagen).FirstOrDefault();
            if ((mImagen == null) || !(mImagen.Estado))
            {
                throw new Exception("No se ha encontrado la Imagen");
            }
            return mImagen;
        }

        public List<string> GetAllNamesFromImages()
        {
            List<string> mListasDeNombres = new List<string>();

            foreach (var item in _context.Imagenes)
            {
                mListasDeNombres.Add(item.Nombre);
            }

            return mListasDeNombres;
        }

        public void Insert(Imagen pImagen)
        {
            Imagen mBusquedaDeImagenPorHash = _context.Imagenes.Where(x => x.Hash == pImagen.Hash).FirstOrDefault();
            Imagen mBusquedaDeImagenPorNombre = _context.Imagenes.Where(x => x.Nombre == pImagen.Nombre).FirstOrDefault();
            if ((mBusquedaDeImagenPorHash != null) && (mBusquedaDeImagenPorNombre != null))
            {
                if (!(mBusquedaDeImagenPorNombre.Estado))
                {
                    mBusquedaDeImagenPorNombre.Estado = true;
                    _context.Imagenes.Attach(mBusquedaDeImagenPorNombre);
                }
                else
                {
                    throw new Exception("La Imagen ya existe");
                }
            }
            else
            {
                _context.Imagenes.Add(pImagen);
            }
        }

        public void Delete(Imagen pImagen)
        {
            Imagen encontrado = _context.Imagenes.Find(pImagen.Id);
            if ((encontrado == null) || !(pImagen.Estado))
            {
                throw new Exception("La Imagen no se ha encontrado");
            }
            pImagen.Estado = false;
            _context.Imagenes.Attach(pImagen);

        }

        public void DeleteById(int pId)
        {
            Imagen pImagen = _context.Imagenes.Find(pId);
            if ((pImagen == null) || !(pImagen.Estado))
            {
                throw new Exception("La Imagen no se ha encontrado");
            }
            pImagen.Estado = false;
            _context.Imagenes.Attach(pImagen);
        }

        public void Update(Imagen pImagen)
        {
            Imagen imagenAnterior = _context.Imagenes.Find(pImagen.Id);
            if (imagenAnterior == null)
            {
                throw new Exception("No se ha encontrado el banner que se quiere modificar");
            }
            _context.Imagenes.Attach(pImagen);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
