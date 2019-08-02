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
using Vista.EntityFramework.Services;
using Vista.Core.Models;
using System.Data.Entity;
using System.Drawing;

namespace Controlador
{
    /// <summary>
    /// Clase fachada, de donde se va a llamar a los repositorios para realizar las operaciones
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
        private readonly ILogger cLogger;
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
            cLogger = pLogger;
        }


        ///Métodos de Fuentes

        /// <summary>
        /// Agrega una fuente de texto fijo
        /// </summary>
        /// 
        public void AddFuenteTXT(FuenteTextoFijo pFuenteTextoFijo)
        {
            if (cRepositoryBaseTXT.Filter(x => x.Titulo == pFuenteTextoFijo.Titulo) != null)
            {
                cRepositoryBaseTXT.Add(pFuenteTextoFijo);
                cRepositoryBaseTXT.SaveChanges();
            }
            else
            {
                throw new Exception("Ya existe una fuente con ese nombre.");
            }
        }
        /// <summary>
        /// Actualiza el valor de la fuente RSS a partir de la URL
        /// </summary>
        /// <param name="pFuenteRSS"></param>
        public void UpdateValueRSS(FuenteRSS pFuenteRSS)
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
        /// <summary>
        /// Obtiene todas las fuentes RSS
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FuenteRSS> GetAllRSS()
        {
            return cRepositoryBaseRSS.GetAll().ToList();
        }

        /// <summary>
        /// Obtiene todas las fuentes TXT
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FuenteTextoFijo> GetAllTXT()
        {
            return cRepositoryBaseTXT.GetAll().ToList();
        }

        /// <summary>
        /// Agrega una fuente RSS
        /// </summary>
        /// <param name="pFuenteRSS"></param>
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
                    cRepositoryBaseRSS.SaveChanges();
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
        /// <summary>
        /// Borra una fuente RSS
        /// </summary>
        /// <param name="pFuenteRSS"></param>
        public void DeleteFuenteRSS(FuenteRSS pFuenteRSS)
        {
            cRepositoryBaseRSS.DeleteById(pFuenteRSS.Id);
            cRepositoryBaseRSS.SaveChanges();
        }
        /// <summary>
        /// Borra una fuente TXT
        /// </summary>
        /// <param name="pFuenteTXT"></param>
        public void DeleteFuenteTXT(FuenteTextoFijo pFuenteTXT)
        {
            cRepositoryBaseTXT.DeleteById(pFuenteTXT.Id);
            cRepositoryBaseTXT.SaveChanges();
        }
        /// <summary>
        /// Obtiene una fuente RSS dado el ID
        /// </summary>
        /// <param name="pFuenteRSS"></param>
        /// <returns></returns>
        public FuenteRSS GetFuenteRSS(FuenteRSS pFuenteRSS)
        {
            return cRepositoryBaseRSS.GetById(pFuenteRSS.Id);
        }

        /// <summary>
        /// Obtiene una fuente TXT dado el ID
        /// </summary>
        /// <param name="pFuenteTXT"></param>
        /// <returns></returns>
        public FuenteTextoFijo GetFuenteTXT(FuenteTextoFijo pFuenteTXT)
        {
            return cRepositoryBaseTXT.GetById(pFuenteTXT.Id);
        }

        /// <summary>
        /// Actualiza una fuente RSS
        /// </summary>
        /// <param name="pFuenteRSS"></param>
        public void UpdateFuenteRSS(FuenteRSS pFuenteRSS)
        {
            cRepositoryBaseRSS.Update(pFuenteRSS);
            cRepositoryBaseRSS.SaveChanges();
        }
        /// <summary>
        /// Actualiza una fuente TXT
        /// </summary>
        /// <param name="pFuenteTXT"></param>
        public void UpdateFuenteTXT(FuenteTextoFijo pFuenteTXT)
        {
            cRepositoryBaseTXT.Update(pFuenteTXT);
            cRepositoryBaseTXT.SaveChanges();
        }

        //Métodos relacionados a Imagenes

        /// <summary>
        /// Devuelve un BitMap dado un array de bytes que corresponden al hash de la imagen
        /// </summary>
        /// <param name="pImagen"></param>
        /// <returns></returns>
        public Bitmap ByteToImage(byte[] pImagen)
        {
            return cImagenRepository.ByteToImage(pImagen);
        }
        /// <summary>
        /// Devuelve un array de bytes que corresponden al hash de la imagen, dado un pictureBox
        /// </summary>
        /// <param name="pPictureBox"></param>
        /// <returns></returns>
        public byte[] ImageToByteArray(PictureBox pPictureBox)
        {
            return cImagenRepository.ImageToByteArray(pPictureBox);
        }
        /// <summary>
        /// Agrega una imagen a la DB
        /// </summary>
        /// <param name="pImagen"></param>
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
        /// <summary>
        /// Borra una imagen de la DB
        /// </summary>
        /// <param name="pImagen"></param>
        public void DeleteImagen(Imagen pImagen)
        {
            var mImagenABorrar = cRepositoryBaseImagen.Filter(x => x.Nombre == pImagen.Nombre).FirstOrDefault();
            if (mImagenABorrar.Campanias.Count > 0)
            {
                cLogger.Debug("La imagen con id " + mImagenABorrar.Id + "no puede eliminarse porque una o más campañas la contienen como imagen a mostrar.");
                throw new Exception("La imagen pertenece a una o más campañas, no puede eliminarse.");
            }
            if (pImagen.Nombre != "")
            {
                cImagenRepository.DeleteByName(pImagen.Nombre);
            }
            else
            {
                cImagenRepository.DeleteByHash(pImagen.Hash);
            }
            cRepositoryBaseImagen.SaveChanges();
        }
        /// <summary>
        /// Actualiza una imagen
        /// </summary>
        /// <param name="pImagen"></param>
        public void UpdateImagen(Imagen pImagen)
        {
            cRepositoryBaseImagen.Update(pImagen);
            cRepositoryBaseImagen.SaveChanges();
        }

        /// <summary>
        /// Obtiene una imagen por ID
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Imagen GetImagenById(int pId)
        {
            return cRepositoryBaseImagen.GetById(pId);
        }
        /// <summary>
        /// Obtiene una imagen por nombre
        /// </summary>
        /// <param name="pNombreImagen"></param>
        /// <returns></returns>
        public Imagen GetImagenByName(string pNombreImagen)
        {
            return cImagenRepository.GetByName(pNombreImagen);
        }
        /// <summary>
        /// Obtiene todos los nombres de las imagenes
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllNamesFromImages()
        {
            return cImagenRepository.GetAllNamesFromImages();
        }
        /// <summary>
        /// Obtiene todas las imagenes
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Imagen> GetAllImagen()
        {
            return cRepositoryBaseImagen.GetAll().ToList();
        }
        /// <summary>
        /// Obtiene todas las imagenes, en formato List<Imagen>
        /// </summary>
        /// <returns></returns>
        public List<Imagen> GetImagenes()
        {
            return cRepositoryBaseImagen.GetAll().ToList();
        }


        ///Metodos relacionados a Campañas

        /// <summary>
        /// Agrega una campaña a la db
        /// </summary>
        /// <param name="pCampania"></param>
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
        /// <summary>
        /// Obtiene la campaña en el instante de tiempo "ahora"
        /// </summary>
        /// <returns></returns>
        public Campania GetCampaniaNow()
        {
            Dictionary<string, List<Campania>> mDiccionario = AvailableTimes(DateTime.Now, DateTime.Now);
            
            List<Campania> mListaCampaniasMenoresIguales = new List<Campania>();
            mListaCampaniasMenoresIguales = mDiccionario["MenoresIguales"];
            List<Campania> mListaCampaniasIntermedias = new List<Campania>();
            mListaCampaniasIntermedias = mDiccionario["Intermedias"];
            List<Campania> mListaCampaniasMayores = new List<Campania>();
            mListaCampaniasMayores = mDiccionario["Mayores"];
            //Opción 1: 
            int mCantidadDias = 0;
            foreach (Campania mCampania in mListaCampaniasMenoresIguales)
            {
                if (mCampania.FechaInicio.Date < DateTime.Now.Date)
                {
                    mCantidadDias = (mCampania.FechaFin.Date - DateTime.Now.Date).Days + 1;
                    if (mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                    {
                        for (int i = (mCampania.FechaInicio.Hour); i < 24; i++)
                        {
                            if(i == DateTime.Now.Hour)
                            {
                                return mCampania;
                            }
                        }
                        for (int i = 0; i <= (mCampania.FechaFin.Hour); i++)
                        {
                            if (i == DateTime.Now.Hour)
                            {
                                return mCampania;
                            }
                        }
                    }
                    else
                    {
                        for (int i = (mCampania.FechaInicio.Hour); i <= (mCampania.FechaFin.Hour); i++)
                        {
                            if (i == DateTime.Now.Hour)
                            {
                                return mCampania;
                            }
                        }
                    }

                }
                else
                {
                    mCantidadDias = (mCampania.FechaFin.Date - mCampania.FechaInicio.Date).Days;
                    int mDiaInicio = (mCampania.FechaInicio.Date - DateTime.Now.Date).Days;
                    mCantidadDias = mCantidadDias + mDiaInicio;
                    for (int j = mDiaInicio; j <= mCantidadDias; j++)
                    {
                        if (mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                        {
                            for (int i = (mCampania.FechaInicio.Hour); i < 24; i++)
                            {
                                if (i == DateTime.Now.Hour)
                                {
                                    return mCampania;
                                }
                            }
                            for (int i = 0; i <= (mCampania.FechaFin.Hour); i++)
                            {
                                if (i == DateTime.Now.Hour)
                                {
                                    return mCampania;
                                }
                            }
                        }
                        else
                        {
                            for (int i = (mCampania.FechaInicio.Hour); i <= (mCampania.FechaFin.Hour); i++)
                            {
                                //if (j < mDias)
                                //{
                                    if (i == DateTime.Now.Hour)
                                    {
                                        return mCampania;
                                    }
                                //}
                            }
                        }
                    }

                }
            }
        
            //Opción 2:
            foreach (Campania mCampania in mListaCampaniasIntermedias)
            {
                if (mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                {
                    for (int i = (mCampania.FechaInicio.Hour); i < 24; i++)
                    {
                        if (i == DateTime.Now.Hour)
                        {
                            return mCampania;
                        }
                    }
                    for (int i = 0; i <= (mCampania.FechaFin.Hour); i++)
                    {
                        if (i == DateTime.Now.Hour)
                        {
                            return mCampania;
                        }
                    }
                }
                else
                {
                    for (int i = (mCampania.FechaInicio.Hour); i <= (mCampania.FechaFin.Hour); i++)
                    {
                        if (i == DateTime.Now.Hour)
                        {
                            return mCampania;
                        }
                    }
                }
            }

            //Opción 3:
            foreach (Campania mCampania in mListaCampaniasMayores)
            {
                if (mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                {
                    for (int i = (mCampania.FechaInicio.Hour); i < 24; i++)
                    {
                        if (i == DateTime.Now.Hour)
                        {
                            return mCampania;
                        }
                    }
                    for (int i = 0; i <= (mCampania.FechaFin.Hour); i++)
                    {
                        if (i == DateTime.Now.Hour)
                        {
                            return mCampania;
                        }
                    }
                }
                else
                {
                    for (int i = (mCampania.FechaInicio.Hour); i <= (mCampania.FechaFin.Hour); i++)
                    {
                        if (i == DateTime.Now.Hour)
                        {
                            return mCampania;
                        }
                    }
                }
                
                
            }
            return null;
        }


        /// <summary>
        /// Obtiene todas las campañas
        /// </summary>
        /// <returns></returns>
        public List<Campania> GetAllCampania()
        {
            return cRepositoryBaseCampania.GetAll().ToList();
        }

        /// <summary>
        /// Obtiene una campaña por ID
        /// </summary>
        /// <param name="pCampania"></param>
        /// <returns></returns>
        public Campania GetCampania(Campania pCampania)
        {
            return cRepositoryBaseCampania.GetById(pCampania.Id);
        }
        /// <summary>
        /// Obtiene las fechas disponibles para una campaña
        /// </summary>
        /// <param name="pFechaInicio"></param>
        /// <param name="pFechaFin"></param>
        /// <returns></returns>
        public Dictionary<string, List<Campania>> AvailableTimes(DateTime pFechaInicio, DateTime pFechaFin)
        {
            return cCampaniaRepository.AvailableTimes(pFechaInicio, pFechaFin);
        }
        /// <summary>
        /// Borra una campaña.
        /// </summary>
        /// <param name="pCampania"></param>
        public void DeleteCampania(Campania pCampania)
        {
            cRepositoryBaseCampania.DeleteById(pCampania.Id);
            cRepositoryBaseCampania.SaveChanges();
        }
        /// <summary>
        /// Obtiene las imagenes de una campaña.
        /// </summary>
        /// <param name="pCampania"></param>
        /// <returns></returns>
        public List<Imagen> GetImagesOfCampania(Campania pCampania)
        {
            return cCampaniaRepository.GetImagenes(pCampania);
        }
        /// <summary>
        /// Actualiza una campaña
        /// </summary>
        /// <param name="pCampania"></param>
        public void UpdateCampania(Campania pCampania)
        {
            cRepositoryBaseCampania.Update(pCampania);
            cRepositoryBaseCampania.SaveChanges();
        }
        /// <summary>
        /// Obtiene los horarios disponibles para agregar una campaña
        /// </summary>
        /// <param name="pCampania"></param>
        /// <param name="pDictionary"></param>
        /// <returns></returns>
        public bool AvailableHoursCampania(Campania pCampania, Dictionary<string, List<Campania>> pDictionary)
        {
            return cCampaniaRepository.AvailableHours(pCampania, pDictionary);
        }


        ///Métodos relacionados a Banners
        ///
        /// 
        /// 


        /// <summary>
        /// Agrega un banner
        /// </summary>
        /// <param name="pBanner"></param>
        public void AddBanner(Banner pBanner)
        {
            Banner mBusquedaDeBannerPorNombre = cRepositoryBaseBanner.Filter(x => x.Nombre == pBanner.Nombre).FirstOrDefault();

            if (mBusquedaDeBannerPorNombre != null)
            {
                throw new Exception("Un Banner con ese nombre ya existe, elija otro.");
            }
            cRepositoryBaseBanner.Add(pBanner);
            cRepositoryBaseBanner.SaveChanges();
        }
        /// <summary>
        /// Obtiene las fechas disponibles para un banner.
        /// </summary>
        /// <param name="pFechaInicio"></param>
        /// <param name="pFechaFin"></param>
        /// <returns></returns>
        public Dictionary<string, List<Banner>> AvailableTimesBanner(DateTime pFechaInicio, DateTime pFechaFin)
        {
            return cBannerRepository.AvailableTimes(pFechaInicio, pFechaFin);
        }
        /// <summary>
        /// Obtiene todos los banners
        /// </summary>
        /// <returns></returns>
        public List<Banner> GetAllBanner()
        {
            return cRepositoryBaseBanner.GetAll().ToList();
        }
        /// <summary>
        /// Obtiene el banner en el instante de tiempo "ahora"
        /// </summary>
        /// <returns></returns>
        public Banner GetBannerNow()
        {
            Dictionary<string, List<Banner>> mDiccionario = AvailableTimesBanner(DateTime.Now, DateTime.Now);

            List<Banner> mListaBannersMenoresIguales = new List<Banner>();
            mListaBannersMenoresIguales = mDiccionario["MenoresIguales"];
            List<Banner> mListaBannersIntermedias = new List<Banner>();
            mListaBannersIntermedias = mDiccionario["Intermedias"];
            List<Banner> mListaBannersMayores = new List<Banner>();
            mListaBannersMayores = mDiccionario["Mayores"];
            //Opción 1: 
            int mCantidadDias = 0;
            foreach (Banner mBanner in mListaBannersMenoresIguales)
            {
                if (mBanner.FechaInicio.Date < DateTime.Now.Date)
                {
                    mCantidadDias = (mBanner.FechaFin.Date - DateTime.Now.Date).Days + 1;
                    if (mBanner.FechaInicio.Hour > mBanner.FechaFin.Hour)
                    {
                        for (int i = (mBanner.FechaInicio.Hour); i < 24; i++)
                        {
                            if (i == DateTime.Now.Hour)
                            {
                                return mBanner;
                            }
                        }
                        for (int i = 0; i <= (mBanner.FechaFin.Hour); i++)
                        {
                            if (i == DateTime.Now.Hour)
                            {
                                return mBanner;
                            }
                        }
                    }
                    else
                    {
                        for (int i = (mBanner.FechaInicio.Hour); i <= (mBanner.FechaFin.Hour); i++)
                        {
                            if (i == DateTime.Now.Hour)
                            {
                                return mBanner;
                            }
                        }
                    }

                }
                else
                {
                    mCantidadDias = (mBanner.FechaFin.Date - mBanner.FechaInicio.Date).Days;
                    int mDiaInicio = (mBanner.FechaInicio.Date - DateTime.Now.Date).Days;
                    mCantidadDias = mCantidadDias + mDiaInicio;
                    for (int j = mDiaInicio; j <= mCantidadDias; j++)
                    {
                        if (mBanner.FechaInicio.Hour > mBanner.FechaFin.Hour)
                        {
                            for (int i = (mBanner.FechaInicio.Hour); i < 24; i++)
                            {
                                if (i == DateTime.Now.Hour)
                                {
                                    return mBanner;
                                }
                            }
                            for (int i = 0; i <= (mBanner.FechaFin.Hour); i++)
                            {
                                if (i == DateTime.Now.Hour)
                                {
                                    return mBanner;
                                }
                            }
                        }
                        else
                        {
                            for (int i = (mBanner.FechaInicio.Hour); i <= (mBanner.FechaFin.Hour); i++)
                            {
                                //if (j < mDias)
                                //{
                                if (i == DateTime.Now.Hour)
                                {
                                    return mBanner;
                                }
                                //}
                            }
                        }
                    }

                }
            }

            //Opción 2:
            foreach (Banner mBanner in mListaBannersIntermedias)
            {
                if (mBanner.FechaInicio.Hour > mBanner.FechaFin.Hour)
                {
                    for (int i = (mBanner.FechaInicio.Hour); i < 24; i++)
                    {
                        if (i == DateTime.Now.Hour)
                        {
                            return mBanner;
                        }
                    }
                    for (int i = 0; i <= (mBanner.FechaFin.Hour); i++)
                    {
                        if (i == DateTime.Now.Hour)
                        {
                            return mBanner;
                        }
                    }
                }
                else
                {
                    for (int i = (mBanner.FechaInicio.Hour); i <= (mBanner.FechaFin.Hour); i++)
                    {
                        if (i == DateTime.Now.Hour)
                        {
                            return mBanner;
                        }
                    }
                }
            }

            //Opción 3:
            foreach (Banner mBanner in mListaBannersMayores)
            {
                if (mBanner.FechaInicio.Hour > mBanner.FechaFin.Hour)
                {
                    for (int i = (mBanner.FechaInicio.Hour); i < 24; i++)
                    {
                        if (i == DateTime.Now.Hour)
                        {
                            return mBanner;
                        }
                    }
                    for (int i = 0; i <= (mBanner.FechaFin.Hour); i++)
                    {
                        if (i == DateTime.Now.Hour)
                        {
                            return mBanner;
                        }
                    }
                }
                else
                {
                    for (int i = (mBanner.FechaInicio.Hour); i <= (mBanner.FechaFin.Hour); i++)
                    {
                        if (i == DateTime.Now.Hour)
                        {
                            return mBanner;
                        }
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Borrar un banner
        /// </summary>
        /// <param name="pBanner"></param>
        public void DeleteBanner(Banner pBanner)
        {
            cRepositoryBaseBanner.DeleteById(pBanner.Id);
            cRepositoryBaseBanner.SaveChanges();
        }
        /// <summary>
        /// Obtiene un banner, dado un ID
        /// </summary>
        /// <param name="pBanner"></param>
        /// <returns></returns>
        public Banner GetBanner(Banner pBanner)
        {
            return cRepositoryBaseBanner.GetById(pBanner.Id);
        }
        /// <summary>
        /// Actualiza un banner
        /// </summary>
        /// <param name="pBanner"></param>
        public void UpdateBanner(Banner pBanner)
        {
            cRepositoryBaseBanner.Update(pBanner);
            cRepositoryBaseBanner.SaveChanges();
        }
        /// <summary>
        /// Verifica si en el rango de horario que se le pasa, está libre 
        /// </summary>
        /// <param name="pBanner"></param>
        /// <param name="pDictionary"></param>
        /// <returns></returns>
        public bool AvailableHoursBanner(Banner pBanner, Dictionary<string, List<Banner>> pDictionary)
        {
            return cBannerRepository.AvailableHours(pBanner, pDictionary);
        }
    }
}
