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
    /// Clase repositorio de la Fuente, donde se va a usar el context para realizar las operaciones
    /// </summary>
    public class FuenteRepository : IRepository<Fuente>
    {
        private readonly DigitalBillboardContext _context;

        public FuenteRepository()
        {
            _context = new DigitalBillboardContext();
        }

        public IQueryable<Fuente> Get(Expression<Func<Fuente, bool>> predicate)
        {
            IQueryable<Fuente> query = _context.Fuentes.TakeWhile(predicate);
            if (query.Count() == 0)
            {
                throw new Exception("No hay Fuentes");
            }
            return query;
        }

        public IEnumerable<Fuente> GetAll()
        {
            List<Fuente> listaFuentes = _context.Fuentes.ToList();
            List<Fuente> activos = new List<Fuente>();
            foreach (Fuente item in listaFuentes)
            {
                if (item.Estado)
                {
                    activos.Add(item);
                }
            }
            if (activos.Count() == 0)
            {
                throw new Exception("No hay Fuentes");
            }
            return activos;
        }

        public Fuente GetById(int pId)
        {
            Fuente fuente = _context.Fuentes.Find(pId);
            if ((fuente == null) || !(fuente.Estado))
            {
                throw new Exception("No se ha encontrado la Fuente");
            }
            return fuente;
        }

        public void Insert(Fuente pFuente)
        {
            Fuente fuente = _context.Fuentes.Find(pFuente.Id);
            if (fuente != null)
            {
                if (!(fuente.Estado))
                {
                    fuente.Estado = true;
                    _context.Fuentes.Attach(fuente);
                }
                else
                {
                    throw new Exception("La Fuente ya existe");
                }
            }
            else
            {
                _context.Fuentes.Add(pFuente);
            }
        }

        public void Delete(Fuente pFuente)
        {
            Fuente encontrado = _context.Fuentes.Find(pFuente.Id);
            if ((encontrado == null) || !(pFuente.Estado))
            {
                throw new Exception("La Fuente no se ha encontrado");
            }
            pFuente.Estado = false;
            _context.Fuentes.Attach(pFuente);

        }

        public void DeleteById(int pId)
        {
            Fuente pFuente = _context.Fuentes.Find(pId);
            if ((pFuente == null) || !(pFuente.Estado))
            {
                throw new Exception("La Fuente no se ha encontrado");
            }
            pFuente.Estado = false;
            _context.Fuentes.Attach(pFuente);
        }

        public void Update(Fuente pFuente)
        {
            Fuente fuenteAnterior = _context.Fuentes.Find(pFuente.Id);
            if (fuenteAnterior == null)
            {
                throw new Exception("No se ha encontrado el banner que se quiere modificar");
            }
            _context.Fuentes.Attach(pFuente);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
