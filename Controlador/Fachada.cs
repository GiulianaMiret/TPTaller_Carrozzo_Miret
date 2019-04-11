using EntityFramework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

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
        private readonly IRepository<Banner> _bannerRepository;
        private readonly IRepository<Campania> _campaniaRepository;
        private readonly IRepository<Fuente> _fuenteRepository;
        private readonly IRepository<Imagen> _imagenRepository;

        /// <summary>
        /// Constructor de la clase Fachada que basicamente inyecta las dependencias de los repositorios con Ninject.
        /// </summary>
        /// <param name="bannerRepository"></param>
        /// <param name="campaniaRepository"></param>
        public Fachada(IRepository<Banner> bannerRepository, IRepository<Campania> campaniaRepository, IRepository<Fuente> fuenteRepository, IRepository<Imagen> imagenRepository)
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

            _bannerRepository.Insert(banner);
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

            _bannerRepository.Insert(banner);
        }

        public void newFuente(string pURL, string pDescripcion, BannerRSS pBanner)
        {
            Fuente fuente = new Fuente();
            //fuente.Id
            fuente.Estado = true;
            fuente.URL = pURL;
            fuente.Descripcion = pDescripcion;
            fuente.BannerRSS = pBanner;

            _fuenteRepository.Insert(fuente);
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

            _campaniaRepository.Insert(campania);
        }

        public void newImagen(string pNombre, byte pHash, Campania pCampania)
        {
            Imagen imagen = new Imagen();
            //imagen.Id
            imagen.Estado = true;
            imagen.Nombre = pNombre;
            imagen.Hash = pHash;
            imagen.Campania = pCampania;

            _imagenRepository.Insert(imagen);
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
            _bannerRepository.Delete(pBanner);
        }

        public void deleteBannerTXT(BannerTextoFijo pBanner)
        {
            _bannerRepository.Delete(pBanner);
        }

        public void deleteFuente(Fuente pFuente)
        {
            _fuenteRepository.Delete(pFuente);
        }

        public void deleteCampania(Campania pCampania)
        {
            _campaniaRepository.Delete(pCampania);
        }

        public void deleteImagen(Imagen pImagen)
        {
            _imagenRepository.Delete(pImagen);
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
            _bannerRepository.DeleteById(pId);
        }

        public void deleteByIdBannerTXT(int pId)
        {
            _bannerRepository.DeleteById(pId);
        }

        public void deleteByIdFuente(int pId)
        {
            _fuenteRepository.DeleteById(pId);
        }

        public void deleteByIdCampania(int pId)
        {
            _campaniaRepository.DeleteById(pId);
        }

        public void deleteByIdImagen(int pId)
        {
            _imagenRepository.DeleteById(pId);
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
            _bannerRepository.Update(pBanner);
        }

        public void updateBannerTXT (BannerTextoFijo pBanner)
        {
            _bannerRepository.Update(pBanner);
        }

        public void updateFuente (Fuente pFuente)
        {
            _fuenteRepository.Update(pFuente);
        }

        public void updateCampania (Campania pCampania)
        {
            _campaniaRepository.Update(pCampania);
        }

        public void updateImagen (Imagen pImagen)
        {
            _imagenRepository.Update(pImagen);
        }

        /// <summary>
        /// Métodos para obtener una entidad mediante su ID:
        ///     getByIdBannerRSS
        ///     getByIdBannerTXT
        ///     getByIdFuente
        ///     getByIdCampania
        ///     getByIdImagen
        /// </summary>
    }
}
