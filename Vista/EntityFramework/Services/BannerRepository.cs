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
        private DbSet<Banner> cDbSetBanner;

        public BannerRepository(DigitalBillboardContext pContext)
        {
            cDbSetBanner = pContext.Set<Banner>();         
        }        
        
        public Banner GetBannerNow()
        {
            Banner mBanner = cDbSetBanner.Where(x=> x.FechaInicio < DateTime.Now && x.FechaFin > DateTime.Now).FirstOrDefault();
            return mBanner;
        }

        public Dictionary<string, List<Banner>> AvailableTimes(DateTime pFechaInicio, DateTime pFechaFin)
        {
            List<Banner> mListaTodasLosBanners = cDbSetBanner.ToList();

            //Opción 1: 
            List<Banner> mListaBannersMenoresIguales = mListaTodasLosBanners.Where(x => (x.FechaFin <= pFechaFin) && (x.FechaFin >= pFechaInicio)).ToList();

            //Opción 2:
            List<Banner> mListaBannersIntermedias = mListaTodasLosBanners.Where(x => (x.FechaFin > pFechaFin) && (x.FechaInicio <= pFechaFin) && (x.FechaInicio >= pFechaInicio)).ToList();

            //Opción 3:
            List<Banner> mListaBannersMayores = mListaTodasLosBanners.Where(x => (x.FechaInicio < pFechaInicio) && (x.FechaFin > pFechaFin)).ToList();

            Dictionary<string, List<Banner>> mDiccionarioDeListas = new Dictionary<string, List<Banner>>();
            mDiccionarioDeListas.Add("MenoresIguales", mListaBannersMenoresIguales);
            mDiccionarioDeListas.Add("Intermedias", mListaBannersIntermedias);
            mDiccionarioDeListas.Add("Mayores", mListaBannersMayores);


            return mDiccionarioDeListas;

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

    }
}
