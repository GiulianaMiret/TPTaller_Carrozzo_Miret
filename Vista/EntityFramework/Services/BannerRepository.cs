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
    /// Clase repositorio del banner, donde se va a usar el context para realizar las operaciones
    /// </summary>
    public class BannerRepository : IBannerRepository
    {
        private readonly DigitalBillboardContext cBillBoardContext;
        
        public BannerRepository()
        {
            cBillBoardContext = new DigitalBillboardContext();            
        }
        
        public IQueryable<Banner> Get(Expression<Func<Banner, bool>> predicate)
        {
            IQueryable<Banner> query = cBillBoardContext.Banners.TakeWhile(predicate);
            if (query.Count() == 0)
            {
                throw new Exception("No hay Banners");
            }

            return query;
        }

        public IEnumerable<Banner> GetAll()
        {
            List<Banner> listaBanners = cBillBoardContext.Banners.ToList();
            List<Banner> activos = new List<Banner>();
            foreach (Banner item in listaBanners)
            {
           
               
                    activos.Add(item);
              
            }
            if (activos.Count() == 0)
            {
                throw new Exception("No hay Banners");
            }
            return activos;
        }

        public Banner GetById(int pId)
        {
            Banner banner = cBillBoardContext.Banners.Find(pId);
            if ((banner == null))
            {
                throw new Exception("No se ha encontrado el Banner");
            }
            return banner;
        }

        public void Insert(Banner pBanner)
        {
            Banner banner = cBillBoardContext.Banners.Find(pBanner.Id);
            if (banner != null)
            {
                
            }
            else
            {
                cBillBoardContext.Banners.Add(pBanner);
            }
            
        }

        public void Delete(Banner pBanner)
        {
            Banner encontrado = cBillBoardContext.Banners.Find(pBanner.Id);
            if ((encontrado == null))
            {
                throw new Exception("El banner no se ha encontrado");
            }
            cBillBoardContext.Banners.Attach(pBanner);
                        
        }

        public void DeleteById(int pId)
        {
            Banner pBanner = cBillBoardContext.Banners.Find(pId);
            if ((pBanner == null))
            {
                throw new Exception("El banner no se ha encontrado");
            }

            cBillBoardContext.Banners.Attach(pBanner);
        }

        public void Update(Banner pBanner)
        {
            Banner bannerAnterior = cBillBoardContext.Banners.Find(pBanner.Id);
            if (bannerAnterior == null)
            {
                throw new Exception("No se ha encontrado el banner que se quiere modificar");
            }
            cBillBoardContext.Banners.Attach(pBanner);
        }

        public Banner GetBannerNow()
        {
            Banner mBanner = cBillBoardContext.Banners.Where(x=> x.FechaInicio < DateTime.Now && x.FechaFin > DateTime.Now).FirstOrDefault();
            return mBanner;
        }

        //public void CambiarFuente(int pIdBanner, FuenteRSS pFuente)
        //{
        //    BannerRSS bannerRss = _context.Banners.OfType<BannerRSS>().Where(x => x.Id == pIdBanner).First();
        //    if(bannerRss == null)
        //    {
        //        throw new Exception("No se ha encontrado el Banner");
        //    }
        //    bannerRss.Fuente = pFuente;
        //    _context.Banners.Attach(bannerRss);
        //}

        //public List<BannerRSS> GetAllRss()
        //{
        //    List<BannerRSS> lista = _context.Banners.OfType<BannerRSS>().ToList();
        //    if(lista.Count() == 0)
        //    {
        //        throw new Exception("No se han encontrado Banners RSS");
        //    }
        //    List<BannerRSS> listaActivos = lista.ToList();
        //    if (listaActivos.Count() == 0)
        //    {
        //        throw new Exception("No se han econtrado banners RSS");
        //    }
        //    return listaActivos;
        //}

        //public List<BannerTextoFijo> GetAllTXT()
        //{
        //    List<BannerTextoFijo> lista = _context.Banners.OfType<BannerTextoFijo>().ToList();
        //    if (lista.Count() == 0)
        //    {
        //        throw new Exception("No se han encontrado Banners TXT");
        //    }
        //    List<BannerTextoFijo> listaActivos = lista.ToList();
        //    if (listaActivos.Count() == 0)
        //    {
        //        throw new Exception("No se han econtrado banners TXT");
        //    }
        //    return listaActivos;
        //}

        //public List<Banner> GetAllBannerRSS()
        //{
        //    var result = from banner in _context.Banners
        //                 where banner is BannerRSS
        //                 select banner;
        //    List<Banner> bannerActivo = result.ToList();
        //    if(bannerActivo.Count() == 0)
        //    {
        //        throw new Exception("No se han encontrado Banners");
        //    }
        //    return bannerActivo;
        //}

        //public List<Banner> GetAllBannerTXT()
        //{
        //    var result = from banner in _context.Banners
        //                 where banner is BannerTextoFijo
        //                 select banner;
        //    List<Banner> bannerActivo = result.ToList();
        //    if(bannerActivo.Count() == 0)
        //    {
        //        throw new Exception("No se han encontrado Banners");
        //    }
        //    return bannerActivo;
        //}
    }
}
