using EntityFramework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using System.Linq.Expressions;

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
        private readonly IBannerRepository _bannerRepository;
        private readonly IRepository<Campania> _campaniaRepository;
        private readonly IRepository<Fuente> _fuenteRepository;
        private readonly IRepository<Imagen> _imagenRepository;

        /// <summary>
        /// Constructor de la clase Fachada que basicamente inyecta las dependencias de los repositorios con Ninject.
        /// </summary>
        /// <param name="bannerRepository"></param>
        /// <param name="campaniaRepository"></param>
        public Fachada(IBannerRepository bannerRepository, IRepository<Campania> campaniaRepository, IRepository<Fuente> fuenteRepository, IRepository<Imagen> imagenRepository)
        {
            _bannerRepository = bannerRepository;
            _campaniaRepository = campaniaRepository;
            _fuenteRepository = fuenteRepository;
            _imagenRepository = imagenRepository;
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
        public void newBannerRSS(string pNombre, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin, int pCodigo, string pValor, Fuente pFuente)
        {
            BannerRSS banner = new BannerRSS();
            //banner.Id
            banner.Estado = true;
            banner.Nombre = pNombre;
            banner.FechaInicio = pFechaInicio;
            banner.FechaFin = pFechaFin;
            banner.HoraInicio = pHoraInicio;
            banner.HoraFin = pHoraFin;
            banner.Codigo = pCodigo;
            banner.Valor = pValor;
            banner.Fuente = pFuente;
            try
            {
                _bannerRepository.Insert(banner);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void newBannerTXT(string pNombre, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin, string pTexto)
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
                _bannerRepository.Insert(banner);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void newFuente(string pURL, string pDescripcion, BannerRSS pBanner)
        {
            Fuente fuente = new Fuente();
            //fuente.Id
            fuente.Estado = true;
            fuente.URL = pURL;
            fuente.Descripcion = pDescripcion;
            fuente.BannerRSS = pBanner;
            try
            {
                _fuenteRepository.Insert(fuente);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void newCampania(string pNombre, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin, ICollection<Imagen> pImagenes)
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
                _campaniaRepository.Insert(campania);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void newImagen(string pNombre, byte pHash, Campania pCampania)
        {
            Imagen imagen = new Imagen();
            //imagen.Id
            imagen.Estado = true;
            imagen.Nombre = pNombre;
            imagen.Hash = pHash;
            imagen.Campania = pCampania;
            try
            {
                _imagenRepository.Insert(imagen);
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
        public void deleteBannerRSS(BannerRSS pBanner)
        {
            try
            {
                _bannerRepository.Delete(pBanner);
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }

        public void deleteBannerTXT(BannerTextoFijo pBanner)
        {
            try
            {
                _bannerRepository.Delete(pBanner);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void deleteFuente(Fuente pFuente)
        {
            try
            {
                _fuenteRepository.Delete(pFuente);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void deleteCampania(Campania pCampania)
        {
            try
            {
                _campaniaRepository.Delete(pCampania);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void deleteImagen(Imagen pImagen)
        {
            try
            {
                _imagenRepository.Delete(pImagen);
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
        public void deleteByIdBannerRSS(int pId)
        {
            try
            {
                _bannerRepository.DeleteById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void deleteByIdBannerTXT(int pId)
        {
            try
            {
                _bannerRepository.DeleteById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void deleteByIdFuente(int pId)
        {
            try
            {
                _fuenteRepository.DeleteById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void deleteByIdCampania(int pId)
        {
            try
            {
                _campaniaRepository.DeleteById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void deleteByIdImagen(int pId)
        {
            try
            {
                _imagenRepository.DeleteById(pId);
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
        public void updateBannerRSS (BannerRSS pBanner)
        {
            try
            {
                _bannerRepository.Update(pBanner);
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }

        public void updateBannerTXT (BannerTextoFijo pBanner)
        {
            try
            {
                _bannerRepository.Update(pBanner);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void updateFuente (Fuente pFuente)
        {
            try
            {
                _fuenteRepository.Update(pFuente);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void updateCampania (Campania pCampania)
        {
            try
            {
                _campaniaRepository.Update(pCampania);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void updateImagen (Imagen pImagen)
        {
            try
            {
                _imagenRepository.Update(pImagen);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        /// <summary>
        /// Métodos para obtener una entidad mediante su ID:
        ///     getByIdBanner
        ///     getByIdFuente
        ///     getByIdCampania
        ///     getByIdImagen
        /// </summary>
        public Banner getByIdBanner (int pId)
        {
            try
            {
                return _bannerRepository.GetById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Fuente getByIdFuente (int pId)
        {
            try
            {
                return _fuenteRepository.GetById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Campania getByIdCampania (int pId)
        {
            try
            {
                return _campaniaRepository.GetById(pId);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Imagen getByIdImagen (int pId)
        {
            try
            {
                return _imagenRepository.GetById(pId);
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
        public IEnumerable<Banner> getAllBanner()
        {
            try
            {
                return _bannerRepository.GetAll();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public IEnumerable<Fuente> getAllFuente()
        {
            try
            {
                return _fuenteRepository.GetAll();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public IEnumerable<Campania> getAllCampania()
        {
            try
            {
                return _campaniaRepository.GetAll();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public IEnumerable<Imagen> getAllImagen()
        {
            try
            {
                return _imagenRepository.GetAll();
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
                return _bannerRepository.Get(predicate);
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }

        public IQueryable<Fuente> GetFuente(Expression<Func<Fuente, bool>> predicate)
        {
            try
            {
                return _fuenteRepository.Get(predicate);
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
                return _campaniaRepository.Get(predicate);
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
                return _imagenRepository.Get(predicate);
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
            _bannerRepository.Save();
            _fuenteRepository.Save();
            _campaniaRepository.Save();
            _imagenRepository.Save();
        }

    }
}
