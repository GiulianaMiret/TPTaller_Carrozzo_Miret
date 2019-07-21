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


        public bool AvailableHours(Banner pBanner, Dictionary<string, List<Banner>> pDictionary)
        {
            List<Banner> mListaBannersMenoresIguales = new List<Banner>();
            mListaBannersMenoresIguales = pDictionary["MenoresIguales"];
            List<Banner> mListaBannersIntermedias = new List<Banner>();
            mListaBannersIntermedias = pDictionary["Intermedias"];
            List<Banner> mListaBannersMayores = new List<Banner>();
            mListaBannersMayores = pDictionary["Mayores"];

            List<Banner> mListaAuxiliar = new List<Banner>();
            if (mListaBannersMenoresIguales.Count() > 0)
            {
                //Opción 1
                mListaAuxiliar = mListaBannersMenoresIguales.Where(x =>
                                                        (x.FechaFin.Hour <= pBanner.FechaFin.Hour) &&
                                                        (x.FechaFin.Hour >= pBanner.FechaInicio.Hour) &&
                                                        (x.Id != pBanner.Id)).ToList();
                if (mListaAuxiliar.Count() > 0)
                {
                    return false;
                }
                //Opción 2
                mListaAuxiliar = mListaBannersMenoresIguales.Where(x =>
                                                        (x.FechaFin.Hour > pBanner.FechaFin.Hour) &&
                                                        (x.FechaInicio.Hour <= pBanner.FechaFin.Hour) &&
                                                        (x.FechaInicio.Hour >= pBanner.FechaInicio.Hour) &&
                                                        (x.Id != pBanner.Id)).ToList();

                if (mListaAuxiliar.Count() > 0)
                {
                    return false;
                }

                //Opción 3
                mListaAuxiliar = mListaBannersMenoresIguales.Where(x =>
                                                    (x.FechaInicio.Hour < pBanner.FechaInicio.Hour) &&
                                                    (x.FechaFin.Hour > pBanner.FechaFin.Hour) &&
                                                    (x.Id != pBanner.Id)).ToList();
                if (mListaAuxiliar.Count() > 0)
                {
                    return false;
                }
            }
            if (mListaBannersIntermedias.Count() > 0)
            {
                //Opción 1
                mListaAuxiliar = mListaBannersIntermedias.Where(x =>
                                                        (x.FechaFin.Hour <= pBanner.FechaFin.Hour) &&
                                                        (x.FechaFin.Hour >= pBanner.FechaInicio.Hour) &&
                                                        (x.Id != pBanner.Id)).ToList();
                if (mListaAuxiliar.Count() > 0)
                {
                    return false;
                }
                //Opción 2
                mListaAuxiliar = mListaBannersIntermedias.Where(x =>
                                                        (x.FechaFin.Hour > pBanner.FechaFin.Hour) &&
                                                        (x.FechaInicio.Hour <= pBanner.FechaFin.Hour) &&
                                                        (x.FechaInicio.Hour >= pBanner.FechaInicio.Hour) &&
                                                        (x.Id != pBanner.Id)).ToList();

                if (mListaAuxiliar.Count() > 0)
                {
                    return false;
                }

                //Opción 3
                mListaAuxiliar = mListaBannersIntermedias.Where(x =>
                                                    (x.FechaInicio.Hour < pBanner.FechaInicio.Hour) &&
                                                    (x.FechaFin.Hour > pBanner.FechaFin.Hour) &&
                                                    (x.Id != pBanner.Id)).ToList();
                if (mListaAuxiliar.Count() > 0)
                {
                    return false;
                }
            }
            if (mListaBannersMayores.Count() > 0)
            {
                //Opción 1
                mListaAuxiliar = mListaBannersMayores.Where(x =>
                                                        (x.FechaFin.Hour <= pBanner.FechaFin.Hour) &&
                                                        (x.FechaFin.Hour >= pBanner.FechaInicio.Hour) &&
                                                        (x.Id != pBanner.Id)).ToList();
                if (mListaAuxiliar.Count() > 0)
                {
                    return false;
                }
                //Opción 2
                mListaAuxiliar = mListaBannersMayores.Where(x =>
                                                        (x.FechaFin.Hour > pBanner.FechaFin.Hour) &&
                                                        (x.FechaInicio.Hour <= pBanner.FechaFin.Hour) &&
                                                        (x.FechaInicio.Hour >= pBanner.FechaInicio.Hour) &&
                                                        (x.Id != pBanner.Id)).ToList();

                if (mListaAuxiliar.Count() > 0)
                {
                    return false;
                }

                //Opción 3
                mListaAuxiliar = mListaBannersMayores.Where(x =>
                                                    ((x.FechaInicio.Hour < pBanner.FechaInicio.Hour) &&
                                                    (x.FechaFin.Hour > pBanner.FechaFin.Hour) &&
                                                    (x.Id != pBanner.Id))).ToList();

                if (mListaAuxiliar.Count() > 0)
                {
                    mListaAuxiliar = mListaAuxiliar.Where(x =>
                                                    (x.FechaInicio.Hour < pBanner.FechaFin.Hour) &&
                                                    (x.FechaFin.Hour > pBanner.FechaInicio.Hour)).ToList();
                    if (mListaAuxiliar.Count() > 0)
                    {
                        return false;
                    }

                }
            }
            return true;
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
