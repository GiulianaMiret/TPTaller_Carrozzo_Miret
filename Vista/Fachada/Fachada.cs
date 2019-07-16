﻿using EntityFramework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using System.Linq.Expressions;
using System.Windows.Forms;
using Vista;
using Vista.Logger;
using Vista.EntityFramework.Services;
using Vista.Core.Models;

namespace Controlador
{
    //Como hacer un select en TPH, BankAccount es de tipo BillingDetails.
    //IQueryable<BankAccount> query = from b in context.BillingDetails.OfType<BankAccount>() 
    //select b;


    /// <summary>
    /// Clase fachada, de donde se va a llamar a los repositorios para realizar las operaciones, entre otras cosas
    /// </summary>
    public class Fachada
    {
        /// <summary>
        /// Declaramos las variables repositorios de solo lectura, que se inyectarán con Ninject.
        /// </summary>
        private readonly IBannerRepository cBannerRepository;
        private readonly ICampaniaRepository cCampaniaRepository;
        private readonly IFuenteRepository cFuenteRepository;
        private readonly IImagenRepository cImagenRepository;
        private readonly IRepository<Banner> cRepositoryBaseBanner;
        private readonly IRepository<Campania> cRepositoryBaseCampania;
        private readonly IRepository<FuenteRSS> cRepositoryBaseRSS;
        private readonly IRepository<FuenteTextoFijo> cRepositoryBaseTXT;
        private readonly IRepository<Imagen> cRepositoryBaseImagen;
        private readonly ILogger iLogger;
        /// <summary>
        /// Constructor de la clase Fachada que basicamente inyecta las dependencias de los repositorios con Ninject.
        /// </summary>
        /// <param name="bannerRepository"></param>
        /// <param name="campaniaRepository"></param>
        public Fachada(IBannerRepository pBannerRepository, 
                       ICampaniaRepository pCampaniaRepository, 
                       IFuenteRepository pFuenteRepository, 
                       IImagenRepository pImagenRepository,
                       IRepository<Banner> pRepositoryBaseBanner,
                       IRepository<Campania> pRepositoryBaseCampania,
                       IRepository<FuenteRSS> pRepositoryBaseRSS,
                       IRepository<FuenteTextoFijo> pRepositoryBaseTXT,
                       IRepository<Imagen> pRepositoryBaseImagen,
                       ILogger pLogger)
        {
            cBannerRepository = pBannerRepository;
            cCampaniaRepository = pCampaniaRepository;
            cFuenteRepository = pFuenteRepository;
            cImagenRepository = pImagenRepository;
            cRepositoryBaseBanner = pRepositoryBaseBanner;
            cRepositoryBaseCampania = pRepositoryBaseCampania;
            cRepositoryBaseRSS = pRepositoryBaseRSS;
            cRepositoryBaseTXT = pRepositoryBaseTXT;
            cRepositoryBaseImagen = pRepositoryBaseImagen;
            iLogger = pLogger;
        }


        /// <summary>
        /// Métodos relacionados a Fuentes
        /// </summary>
        /// 
        public void AddFuenteTXT(FuenteTextoFijo pFuenteTextoFijo)
        {
        //    iFuenteRepository.AddFuenteTXT(pFuenteTextoFijo);
        }

        /// <summary>
        /// updateo el valor de la fuente RSS
        /// </summary>
        /// <param name="pFuenteRSS"></param>
        public void UpdateValueRSS (FuenteRSS pFuenteRSS)
        {
            if (Utilidades.InternetDisponible())
            {
                pFuenteRSS.Valor = Utilidades.GetStringFromXMLRSSUrl(pFuenteRSS.URL);
            }
            else
            {
                throw new Exception("No pudo descargarse el feed RSS por falta de conectividad.");
            }
            cRepositoryBaseRSS.Update(pFuenteRSS);
            cRepositoryBaseRSS.SaveChanges();
        }

        public IEnumerable<FuenteRSS> GetAllRSS()
        {
            return cRepositoryBaseRSS.GetAll().ToList();
        }

        public void AddFuenteRSS(FuenteRSS pFuenteRSS)
        {           
                if (Utilidades.InternetDisponible())
                {
                    //si no existe una con el mismo nombre
                    if (cRepositoryBaseRSS.Filter(x => x.Titulo == pFuenteRSS.Titulo) != null)
                    {
                        //convierto en string la URL de la fuente RSS y la agrego
                      pFuenteRSS.Valor = Utilidades.GetStringFromXMLRSSUrl(pFuenteRSS.URL);
                      cRepositoryBaseRSS.Add(pFuenteRSS);
                      cRepositoryBaseImagen.SaveChanges();
                    }
                    else
                    {
                    throw new Exception("Una fuente con ese nombre ya existe.");
                    }
                }
                else
                {
                    throw new Exception("No pudo descargarse el feed RSS por falta de conectividad.");
                }                           
        }

        public string GetTextOfActualBanner()
        {
            if (cBannerRepository.GetBannerNow() == null)
            {
                return "";
            }
            return cBannerRepository.GetBannerNow().Fuente.Valor;
        }
               



        public void AddImagen(Imagen pImagen)
        {
            Imagen mBusquedaDeImagenPorHash = cRepositoryBaseImagen.Filter(x => x.Hash == pImagen.Hash).FirstOrDefault();
            Imagen mBusquedaDeImagenPorNombre = cRepositoryBaseImagen.Filter(x => x.Nombre == pImagen.Nombre).FirstOrDefault();

            if (mBusquedaDeImagenPorHash != null)
            {
                throw new Exception("La imagen ya existe");
            }
            if (mBusquedaDeImagenPorNombre != null)
            {
                throw new Exception("Una imagen con ese nombre ya existe, elija otro.");
            }
            cRepositoryBaseImagen.Add(pImagen);
            
            cRepositoryBaseImagen.SaveChanges();
        }

        public void DeleteImagenByHash(byte[] pHash)
        {
                cImagenRepository.DeleteByHash(pHash);
        }

        public void DeleteImagenByPictureBox(PictureBox pImagen)
        {
            Imagen mImagen = cImagenRepository.GetByHash(Utilidades.ImageToByteArray(pImagen));
            cRepositoryBaseImagen.DeleteById(mImagen.Id);
            cRepositoryBaseImagen.SaveChanges();
        }

        public void DeleteImagenByName(string pName)
        {
            cImagenRepository.DeleteByName(pName);
        }

        public void UpdateImagen (Imagen pImagen)
        {
            cRepositoryBaseImagen.Update(pImagen);
        }


        public Imagen GetImagenById(int pId)
        {
            return cRepositoryBaseImagen.GetById(pId);
        }

        public Imagen GetImagenByName(string pNombreImagen)
        {
            return cImagenRepository.GetByName(pNombreImagen);
        }

        public List<string> GetAllNamesFromImages()
        {
            return cImagenRepository.GetAllNamesFromImages();
        }

        public IEnumerable<Imagen> GetAllImagen()
        {
            return cRepositoryBaseImagen.GetAll().ToList();
        }

        public List<Imagen> GetImagenes()
        {
            return cRepositoryBaseImagen.GetAll().ToList();
        }



        /// <summary>
        /// Métodos relacionados a Campaña
        /// </summary>

        public void AddCampania(Campania pCampania)
        {
            Campania mBusquedaDeCampaniaPorNombre = cRepositoryBaseCampania.Filter(x => x.Nombre == pCampania.Nombre).FirstOrDefault();

            if (mBusquedaDeCampaniaPorNombre != null)
            {
                throw new Exception("Una campania con ese nombre ya existe, elija otro.");
            }
            cRepositoryBaseCampania.Add(pCampania);

            cRepositoryBaseCampania.SaveChanges();
        }

        public IQueryable<Campania> FilterCampania(Expression<Func<Campania, bool>> pExpresion)
        {
            return cRepositoryBaseCampania.Filter(pExpresion);
        }

        public List<Campania> GetAllCampania()
        {
            return cRepositoryBaseCampania.GetAll().ToList();
        }
    }
}
