﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using System.Linq.Expressions;
using System.Data.Entity;
using Vista.Core.Models;

namespace EntityFramework.Services
{
    /// <summary>
    /// Clase repositorio de la Fuente, donde se va a usar el context para realizar las operaciones
    /// </summary>
    public class FuenteRepository
    {
        private readonly DigitalBillboardContext _context;

        public FuenteRepository()
        {
            _context = new DigitalBillboardContext();
        }

        public void AddFuenteRSS(FuenteRSS pFuenteRSS)
        {
            try
            {
                _context.Fuentes.Add(pFuenteRSS);
                _context.SaveChanges();
            }
            catch (Exception mException)
            {
                throw mException;
            }
            
        }        

        //public IQueryable<FuenteRSS> Get(Expression<Func<FuenteRSS, bool>> predicate)
        //{
        //    IQueryable<FuenteRSS> query = _context.Fuentes.TakeWhile(predicate);
        //    if (query.Count() == 0)
        //    {
        //        throw new Exception("No hay Fuentes");
        //    }
        //    return query;
        //}

        //public IEnumerable<FuenteRSS> GetAll()
        //{
        //    List<FuenteRSS> listaFuentes = _context.Fuentes.ToList();
        //    List<FuenteRSS> activos = new List<FuenteRSS>();
        //    foreach (FuenteRSS item in listaFuentes)
        //    {
        //    }
        //    if (activos.Count() == 0)
        //    {
        //        throw new Exception("No hay Fuentes");
        //    }
        //    return activos;
        //}

        //public FuenteRSS GetById(int pId)
        //{
        //    FuenteRSS fuente = _context.Fuentes.Find(pId);
        //    if ((fuente == null))
        //    {
        //        throw new Exception("No se ha encontrado la Fuente");
        //    }
        //    return fuente;
        //}

        //public void Insert(FuenteRSS pFuente)
        //{
        //    FuenteRSS fuente = _context.Fuentes.Find(pFuente.Id);
        //    if (fuente != null)
        //    {

        //        _context.Fuentes.Attach(fuente);
        //    }

        //    else
        //    {
        //        throw new Exception("La Fuente ya existe");
        //    }
        //}

        //public void Delete(FuenteRSS pFuente)
        //{
        //    FuenteRSS encontrado = _context.Fuentes.Find(pFuente.Id);
        //    if (encontrado == null)
        //    {
        //        throw new Exception("La Fuente no se ha encontrado");
        //    }

        //    _context.Fuentes.Attach(pFuente);

        //}

        //public void DeleteById(int pId)
        //{
        //    FuenteRSS pFuente = _context.Fuentes.Find(pId);
        //    if (pFuente == null)
        //    {
        //        throw new Exception("La Fuente no se ha encontrado");
        //    }
        //    _context.Fuentes.Attach(pFuente);
        //}

        //public void Update(FuenteRSS pFuente)
        //{
        //    FuenteRSS fuenteAnterior = _context.Fuentes.Find(pFuente.Id);
        //    if (fuenteAnterior == null)
        //    {
        //        throw new Exception("No se ha encontrado el banner que se quiere modificar");
        //    }
        //    _context.Fuentes.Attach(pFuente);
        //}

        //public void Save()
        //{
        //    _context.SaveChanges();
        //}
    }
}
