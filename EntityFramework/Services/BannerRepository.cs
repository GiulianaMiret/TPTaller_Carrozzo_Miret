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
    /// Clase repositorio del banner, donde se va a usar el context para realizar las operaciones
    /// </summary>
    public class BannerRepository : IBannerRepository
    {
        private readonly DigitalBillboardContext _context;

        public BannerRepository(DigitalBillboardContext context)
        {
            _context = context;
        }
        
        public IQueryable<Banner> Get(Expression<Func<Banner, bool>> predicate)
        {
            IQueryable<Banner> query = _context.Banners.TakeWhile(predicate);
            if (query.Count() == 0)
            {
                throw new Exception("No hay Banners");
            }
            return query;
        }

        public IEnumerable<Banner> GetAll()
        {
            List<Banner> listaBanners = _context.Banners.ToList();
            List<Banner> activos = new List<Banner>();
            foreach (Banner item in listaBanners)
            {
                if (item.Estado)
                {
                    activos.Add(item);
                }
            }
            if (activos.Count() == 0)
            {
                throw new Exception("No hay Banners");
            }
            return activos;
        }

        public Banner GetById(int pId)
        {
            Banner banner = _context.Banners.Find(pId);
            if ((banner == null) || !(banner.Estado))
            {
                throw new Exception("No se ha encontrado el Banner");
            }
            return banner;
        }

        public void Insert(Banner pBanner)
        {
            Banner banner = _context.Banners.Find(pBanner.Id);
            if (banner != null)
            {
                if (!(banner.Estado))
                {
                    banner.Estado = true;
                    _context.Banners.Attach(banner);
                }
                else
                {
                    throw new Exception("El banner ya existe");
                }   
            }
            else
            {
                _context.Banners.Add(pBanner);
            }
            
        }

        public void Delete(Banner pBanner)
        {
            Banner encontrado = _context.Banners.Find(pBanner.Id);
            if ((encontrado == null) || !(pBanner.Estado))
            {
                throw new Exception("El banner no se ha encontrado");
            }
            pBanner.Estado = false;
            _context.Banners.Attach(pBanner);
                        
        }

        public void DeleteById(int pId)
        {
            Banner pBanner = _context.Banners.Find(pId);
            if ((pBanner == null) || !(pBanner.Estado))
            {
                throw new Exception("El banner no se ha encontrado");
            }
            pBanner.Estado = false;
            _context.Banners.Attach(pBanner);
        }

        public void Update(Banner pBanner)
        {
            Banner bannerAnterior = _context.Banners.Find(pBanner.Id);
            if (bannerAnterior == null)
            {
                throw new Exception("No se ha encontrado el banner que se quiere modificar");
            }
            _context.Banners.Attach(pBanner);
        }

        public void Save()
        {
            _context.SaveChanges();
        }


        public void CambiarFuente(int pIdBanner, int pIdFuente)
        {
            Banner banner = _context.Banners.Find(pIdBanner);

        }

        public List<BannerRSS> GetAllRss()
        {
            return _context.Banners.OfType<BannerRSS>().ToList();
        }

        public List<BannerTextoFijo> GetAllTXT()
        {
            return _context.Banners.OfType<BannerTextoFijo>().ToList();
        }

        public List<Banner> GetAllBannerRSS()
        {
            var result = from banner in _context.Banners
                         where banner is BannerRSS
                         select banner;
            return result.ToList();
        }

        public List<Banner> GetAllBannerTXT()
        {
            var result = from banner in _context.Banners
                         where banner is BannerTextoFijo
                         select banner;
            return result.ToList();
        }
    }
}
