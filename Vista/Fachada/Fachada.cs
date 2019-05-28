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
        private readonly FuenteRSSRepository iFuenteRepository;
        private readonly ImagenRepository iImagenRepository;

        /// <summary>
        /// Constructor de la clase Fachada que basicamente inyecta las dependencias de los repositorios con Ninject.
        /// </summary>
        /// <param name="bannerRepository"></param>
        /// <param name="campaniaRepository"></param>
        public Fachada(IBannerRepository bannerRepository, ICampaniaRepository campaniaRepository, FuenteRSSRepository fuenteRepository, ImagenRepository imagenRepository)
        {
            iBannerRepository = bannerRepository;
            iCampaniaRepository = campaniaRepository;
            iFuenteRepository = fuenteRepository;
            iImagenRepository = imagenRepository;
        }


        /// <summary>
        /// New - Delete - Delete by id - Update - Get by id - Get all - Find by id - Find - Save
        /// 
        /// metodos para crear nuevas entidades:
        ///     newBannerRSS
        ///     newBannerTXT
        ///     newFuente
        ///     newCampania
        ///     newImagen
        /// </summary>
        public void AddBannerRSS(string pNombre, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin, int pCodigo, string pValor, FuenteRSS pFuente)
        {
            BannerRSS banner = new BannerRSS();
            //banner.Id
            banner.Estado = true;
            banner.Nombre = pNombre;
            banner.FechaInicio = pFechaInicio;
            banner.FechaFin = pFechaFin;
            banner.HoraInicio = pHoraInicio;
            banner.HoraFin = pHoraFin;
            banner.Valor = pValor;
            banner.Fuente = pFuente;
            try
            {
                iBannerRepository.Insert(banner);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void AddBannerTXT(string pNombre, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin, string pTexto)
        {
            BannerTextoFijo banner = new BannerTextoFijo();
            //banner.Id
            banner.Estado = true;
            banner.Nombre = pNombre;
            banner.FechaInicio = pFechaInicio;
            banner.FechaFin = pFechaFin;
            banner.HoraInicio = pHoraInicio;
            banner.HoraFin = pHoraFin;
            banner.Texto = pTexto;
            try
            {
                iBannerRepository.Insert(banner);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void AddFuente(FuenteRSS pFuente)
        {
            try
            {
                iFuenteRepository.Insert(pFuente);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void AddCampania(string pNombre, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin, ICollection<Imagen> pImagenes)
        {
            Campania campania = new Campania();
            //campania.Id
            campania.Estado = true;
            campania.Nombre = pNombre;
            campania.FechaInicio = pFechaInicio;
            campania.FechaFin = pFechaFin;
            campania.HoraInicio = pHoraInicio;
            campania.HoraFin = pHoraFin;
            campania.Imagenes = pImagenes;
            try
            {
                iCampaniaRepository.Insert(campania);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void AddImagen(Imagen pImagen)
        {
            try
            {
                iImagenRepository.Insert(pImagen);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        /// <summary>
        /// Métodos para dar de baja lógica a una entidad, pasando la entidad:
        ///     deleteBannerRSS
        ///     deleteBannerTXT
        ///     deleteFuente
        ///     deleteCampania
        ///     deleteImagen
        /// </summary>
        public void DeleteBannerRSS(BannerRSS pBanner)
        {
            try
            {
                iBannerRepository.Delete(pBanner);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void DeleteBannerTXT(BannerTextoFijo pBanner)
        {
            try
            {
                iBannerRepository.Delete(pBanner);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void DeleteFuenteRSS(FuenteRSS pFuente)
        {
            try
            {
                iFuenteRepository.Delete(pFuente);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void DeleteCampania(Campania pCampania)
        {
            try
            {
                iCampaniaRepository.Delete(pCampania);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void DeleteImagen(Imagen pImagen)
        {
            try
            {
                iImagenRepository.Delete(pImagen);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void DeleteImagenByHash(byte[] pHash)
        {
            try
            {
                iImagenRepository.DeleteByHash(pHash);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void DeleteImagen(PictureBox pImagen, string pExtension)
        {
            try
            {
                Imagen mImagen = iImagenRepository.GetByHash(Utilidades.ImageToByteArray(pImagen, pExtension));
                iImagenRepository.DeleteById(mImagen.Id);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
        /// <summary>
        /// Métodos para dar de baja lógica a una entidad, pasando el ID:
        ///     deleteByIdBannerRSS
        ///     deleteByIdBannerTXT
        ///     deleteByIdFuente
        ///     deleteByIdCampania
        ///     deleteByIdImagen
        /// </summary>
        public void DeleteByIdBannerRSS(int pId)
        {
            try
            {
                iBannerRepository.DeleteById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void DeleteByIdBannerTXT(int pId)
        {
            try
            {
                iBannerRepository.DeleteById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void DeleteByIdFuente(int pId)
        {
            try
            {
                iFuenteRepository.DeleteById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void DeleteByIdCampania(int pId)
        {
            try
            {
                iCampaniaRepository.DeleteById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void DeleteByIdImagen(int pId)
        {
            try
            {
                iImagenRepository.DeleteById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        /// <summary>
        /// Métodos para modificar una entidad:
        ///     updateBannerRSS
        ///     updateBannerTXT
        ///     updateFuente
        ///     updateCampania
        ///     updateImagen
        /// </summary>
        public void UpdateBannerRSS (BannerRSS pBanner)
        {
            try
            {
                iBannerRepository.Update(pBanner);
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }

        public void UpdateBannerTXT (BannerTextoFijo pBanner)
        {
            try
            {
                iBannerRepository.Update(pBanner);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void UpdateFuente (FuenteRSS pFuente)
        {
            try
            {
                iFuenteRepository.Update(pFuente);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void UpdateCampania (Campania pCampania)
        {
            try
            {
                iCampaniaRepository.Update(pCampania);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void UpdateImagen (Imagen pImagen)
        {
            try
            {
                iImagenRepository.Update(pImagen);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        /// <summary>
        /// Métodos para obtener una entidad mediante su ID:
        ///     getBannerById
        ///     getFuenteById
        ///     getCampaniaById
        ///     getImagenById
        /// </summary>
        public Banner GetBannerById(int pId)
        {
            try
            {
                return iBannerRepository.GetById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public FuenteRSS GetFuenteById(int pId)
        {
            try
            {
                return iFuenteRepository.GetById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Campania GetCampaniaById(int pId)
        {
            try
            {
                return iCampaniaRepository.GetById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Imagen GetImagenById(int pId)
        {
            try
            {
                return iImagenRepository.GetById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Imagen GetImagenByName(string pNombreImagen)
        {
            try
            {
                return iImagenRepository.GetByName(pNombreImagen);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public List<string> GetAllNamesFromImages()
        {
            try
            {
                return iImagenRepository.GetAllNamesFromImages();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
        /// <summary>
        /// Métodos para obtener todas las entidades de un tipo:
        ///     getAllBanner
        ///     getAllFuente
        ///     getAllCampania
        ///     getAllImagen
        /// </summary>
        public IEnumerable<Banner> GetAllBanner()
        {
            try
            {
                return iBannerRepository.GetAll();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public IEnumerable<FuenteRSS> GetAllFuente()
        {
            try
            {
                return iFuenteRepository.GetAll();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public IEnumerable<Campania> GetAllCampania()
        {
            try
            {
                return iCampaniaRepository.GetAll();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public IEnumerable<Imagen> GetAllImagen()
        {
            try
            {
                return iImagenRepository.GetAll();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        /// <summary>
        /// Métodos para buscar todas las entidades que cumplan con la expresión indicada
        ///     GetBanner
        ///     GetFuente
        ///     GetCampania
        ///     GetImagen
        /// </summary>
        public IQueryable<Banner> GetBanner (Expression<Func<Banner, bool>> predicate)
        {
            try
            {
                return iBannerRepository.Get(predicate);
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }

        public IQueryable<FuenteRSS> GetFuente(Expression<Func<FuenteRSS, bool>> predicate)
        {
            try
            {
                return iFuenteRepository.Get(predicate);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public IQueryable<Campania> GetCampania (Expression<Func<Campania, bool>> predicate)
        {
            try
            {
                return iCampaniaRepository.Get(predicate);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public IQueryable<Imagen> GetImagen(Expression<Func<Imagen, bool>> predicate)
        {
            try
            {
                return iImagenRepository.Get(predicate);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        /// <summary>
        /// Métodos para guardar los cambios en la base de datos
        /// </summary>
        public void Save()
        {
            iBannerRepository.Save();
            iFuenteRepository.Save();
            iCampaniaRepository.Save();
            iImagenRepository.Save();
        }

        // -------------- Métodos del IBannerRepository -------------- //

        /// <summary>
        /// Obtiene todos los bannersRSS ACTIVOS
        /// </summary>
        /// <returns>Lista de banners RSS</returns>
        public List<BannerRSS> GetAllRss()
        {
            try
            {
                return iBannerRepository.GetAllRss();
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }

        /// <summary>
        /// Obtiene todos los bannersTextoFijo ACTIVOS
        /// </summary>
        /// <returns>Lista de banners TXT</returns>
        public List<BannerTextoFijo> GetAllTXT()
        {
            try
            {
                return iBannerRepository.GetAllTXT();
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }

        /// <summary>
        /// Obtiene todos los banners ACTIVOS cuya fuente es RSS (pero no da los datos del RSS, solo del banner)
        /// </summary>
        /// <returns>Lista de Banner</returns>
        public List<Banner> GetAllBannerRSS()
        {
            try
            {
                return iBannerRepository.GetAllBannerRSS();
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }

        /// <summary>
        /// Obtiene todos los Banners ACTIVOS cuya fuente es TXT (pero no da los datos del TXT solo del banner)
        /// </summary>
        /// <returns></returns>
        public List<Banner> GetAllBannerTXT()
        {
            try
            {
                return iBannerRepository.GetAllBannerTXT();
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }

        // -------------- Métodos del ICampaniaRepository -------------- //

        /// <summary>
        /// Obtiene todas las imagenes de una campaña
        /// </summary>
        /// <param name="pIdCampania"></param>
        /// <returns>lista de imágenes</returns>
        public List<Imagen> GetImagenes(int pIdCampania)
        {
            try
            {
                return iCampaniaRepository.GetImagenes(pIdCampania);
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }

        /// <summary>
        /// Desactiva (Estado = false) una imagen de una campaña
        /// </summary>
        /// <param name="pIdImagen"></param>
        /// <param name="pIdCampania"></param>
        public void DeleteImagenes(int pIdImagen, int pIdCampania)
        {
            try
            {
                iCampaniaRepository.DeleteImagenes(pIdImagen, pIdCampania);
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }

        /// <summary>
        /// Agrega una imágen a una campaña
        /// </summary>
        /// <param name="pIdImagen"></param>
        /// <param name="pIdCampania"></param>
        public void AddImagenes(int pIdImagen, int pIdCampania)
        {
            try
            {
                iCampaniaRepository.AddImagenes(pIdImagen, pIdCampania);
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }
    }
}
