using EntityFramework.Services;
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

namespace Controlador
{
    /// <summary>
    /// Clase fachada, de donde se va a llamar a los repositorios para realizar las operaciones, entre otras cosas
    /// </summary>
    public class Fachada
    {
        /// <summary>
        /// Declaramos las variables repositorios de solo lectura, que se inyectarán con Ninject.
        /// </summary>
        private readonly IBannerRepository iBannerRepository;
        private readonly ICampaniaRepository iCampaniaRepository;
        private readonly FuenteRepository iFuenteRepository;
        private readonly ImagenRepository iImagenRepository;
        private readonly ILogger iLogger;
        /// <summary>
        /// Constructor de la clase Fachada que basicamente inyecta las dependencias de los repositorios con Ninject.
        /// </summary>
        /// <param name="bannerRepository"></param>
        /// <param name="campaniaRepository"></param>
        public Fachada(IBannerRepository bannerRepository, ICampaniaRepository campaniaRepository, FuenteRepository fuenteRepository, ImagenRepository imagenRepository, ILogger logger)
        {
            iBannerRepository = bannerRepository;
            iCampaniaRepository = campaniaRepository;
            iFuenteRepository = fuenteRepository;
            iImagenRepository = imagenRepository;
            iLogger = logger;
        }

        //--------------------------------------------------------------------------------------------
        /// <summary>
        /// Métodos relacionados a Fuentes
        /// </summary>
        public void VerificarBanner()
        {
            
        }


        public void AddFuenteRSS(FuenteRSS pFuenteRSS)
        {
            try
            {
                if (Utilidades.InternetDisponible())
                {
                    pFuenteRSS.Valor = Utilidades.GetStringFromXMLRSSUrl(pFuenteRSS.URL);
                }
                else
                {
                    iLogger.Debug("No pudo descargarse el feed RSS por falta de conectividad.");
                }
                
                iFuenteRepository.AddFuenteRSS(pFuenteRSS);
            }
            catch (Exception mExcepcion)
            {
                throw mExcepcion;
            }            
        }

        public string GetTextOfActualBanner()
        {
            if (iBannerRepository.GetBannerNow() == null)
            {
                return "";
            }
            return iBannerRepository.GetBannerNow().Fuente.Valor;
        }

        //--------------------------------------------------------------------------------------------
        /// <summary>
        /// Métodos relacionados a Banners
        /// </summary>
        public void AddBanner(Banner pBanner)
        {
            try
            {
                iBannerRepository.Insert(pBanner);
            }
            catch (Exception mExcepcion)
            {
                throw mExcepcion;
            }
        }

        public void DeleteBanner(Banner pBanner)
        {
            try
            {
                iBannerRepository.Delete(pBanner);
            }
            catch (Exception mExcepcion)
            {
                throw mExcepcion;
            }
        }

        public void DeleteByIdBanner(int pId)
        {
            try
            {
                iBannerRepository.DeleteById(pId);
            }
            catch (Exception mExcepcion)
            {
                throw mExcepcion;
            }
        }

        public Banner GetBannerById(int pId)
        {
            try
            {
                return iBannerRepository.GetById(pId);
            }
            catch (Exception mExcepcion)
            {
                throw mExcepcion;
            }
        }

        public IEnumerable<Banner> GetAllBanner()
        {
            try
            {
                return iBannerRepository.GetAll();
            }
            catch (Exception mExcepcion)
            {
                throw mExcepcion;
            }
        }

        /// <summary>
        /// Obtiene todos los bannersRSS ACTIVOS
        /// </summary>
        /// <returns>Lista de banners RSS</returns>
        //public List<BannerRSS> GetAllRss()
        //{
        //    try
        //    {
        //        return iBannerRepository.GetAllRss();
        //    }
        //    catch(Exception exc)
        //    {
        //        throw exc;
        //    }
        //}

        /// <summary>
        /// Obtiene todos los bannersTextoFijo ACTIVOS
        /// </summary>
        /// <returns>Lista de banners TXT</returns>
        //public List<BannerTextoFijo> GetAllTXT()
        //{
        //    try
        //    {
        //        return iBannerRepository.GetAllTXT();
        //    }
        //    catch(Exception exc)
        //    {
        //        throw exc;
        //    }
        //}

        /// <summary>
        /// Obtiene todos los banners ACTIVOS cuya fuente es RSS (pero no da los datos del RSS, solo del banner)
        /// </summary>
        /// <returns>Lista de Banner</returns>
        //public List<Banner> GetAllBannerRSS()
        //{
        //    try
        //    {
        //        return iBannerRepository.GetAllBannerRSS();
        //    }
        //    catch(Exception exc)
        //    {
        //        throw exc;
        //    }
        //}

        /// <summary>
        /// Obtiene todos los Banners ACTIVOS cuya fuente es TXT (pero no da los datos del TXT solo del banner)
        /// </summary>
        /// <returns></returns>
        //public List<Banner> GetAllBannerTXT()
        //{
        //    try
        //    {
        //        return iBannerRepository.GetAllBannerTXT();
        //    }
        //    catch(Exception exc)
        //    {
        //        throw exc;
        //    }
        //}



        //--------------------------------------------------------------------------------------------
        /// <summary>
        /// Métodos relacionados a Campañas
        /// </summary>
        public void AddCampania(Campania pCampania)
        {
            iCampaniaRepository.Insert(pCampania);
        }

        //public void DeleteCampania(Campania pCampania)
        //{
        //    try
        //    {
        //        iCampaniaRepository.Delete(pCampania);
        //    }
        //    catch (Exception mExcepcion)
        //    {
        //        throw mExcepcion;
        //    }
        //}

        //public void DeleteByIdCampania(int pId)
        //{
        //    try
        //    {
        //        iCampaniaRepository.DeleteById(pId);
        //    }
        //    catch (Exception mExcepcion)
        //    {
        //        throw mExcepcion;
        //    }
        //}

        //public void UpdateCampania(Campania pCampania)
        //{
        //    try
        //    {
        //        iCampaniaRepository.Update(pCampania);
        //    }
        //    catch (Exception mExcepcion)
        //    {
        //        throw mExcepcion;
        //    }
        //}

        //public Campania GetCampaniaById(int pId)
        //{
        //    try
        //    {
        //        return iCampaniaRepository.GetById(pId);
        //    }
        //    catch (Exception mExcepcion)
        //    {
        //        throw mExcepcion;
        //    }
        //}

        //public IEnumerable<Campania> GetAllCampania()
        //{
        //    try
        //    {
        //        return iCampaniaRepository.GetAll();
        //    }
        //    catch (Exception mExcepcion)
        //    {
        //        throw mExcepcion;
        //    }
        //}


        /// <summary>
        /// Obtiene todas las imagenes de una campaña
        /// </summary>
        //public List<Imagen> GetImagenes(int pIdCampania)
        //{
        //    try
        //    {
        //        return iCampaniaRepository.GetImagenes(pIdCampania);
        //    }
        //    catch (Exception mExcepcion)
        //    {
        //        throw mExcepcion;
        //    }
        //}

        /// <summary>
        /// Desactiva (Estado = false) una imagen de una campaña
        /// </summary>
        //public void DeleteImagenes(int pIdImagen, int pIdCampania)
        //{
        //    try
        //    {
        //        iCampaniaRepository.DeleteImagenes(pIdImagen, pIdCampania);
        //    }
        //    catch (Exception mExcepcion)
        //    {
        //        throw mExcepcion;
        //    }
        //}

        /// <summary>
        /// Agrega una imágen a una campaña
        /// </summary>
        //public void AddImagenes(int pIdImagen, int pIdCampania)
        //{
        //    try
        //    {
        //        iCampaniaRepository.AddImagenes(pIdImagen, pIdCampania);
        //    }
        //    catch (Exception mExcepcion)
        //    {
        //        throw mExcepcion;
        //    }
        //}


        //--------------------------------------------------------------------------------------------
        /// <summary>
        /// Métodos relacionados a Imagenes
        /// </summary>
        public void AddImagen(Imagen pImagen)
        {
            iImagenRepository.Insert(pImagen);
        }

        public void DeleteImagen(Imagen pImagen)
        {
            iImagenRepository.Delete(pImagen);

        }

        public void DeleteImagenByHash(byte[] pHash)
        {
            iImagenRepository.DeleteByHash(pHash);
        }

        public void DeleteImagenByPictureBox(PictureBox pImagen)
        {
            Imagen mImagen = iImagenRepository.GetByHash(Utilidades.ImageToByteArray(pImagen));
            iImagenRepository.DeleteById(mImagen.Id);
        }

        public void DeleteImagenByName(string pName)
        {
            iImagenRepository.DeleteByName(pName);

        }

        public void UpdateImagen(Imagen pImagen)
        {
            iImagenRepository.Update(pImagen);
        }

        public Imagen GetImagenById(int pId)
        {
            return iImagenRepository.GetById(pId);
        }

        public Imagen GetImagenByName(string pNombreImagen)
        {
            return iImagenRepository.GetByName(pNombreImagen);
        }

        public List<string> GetAllNamesFromImages()
        {
            return iImagenRepository.GetAllNamesFromImages();
        }

        public IEnumerable<Imagen> GetAllImagen()
        {
            return iImagenRepository.GetAll();
        }

    }
}
