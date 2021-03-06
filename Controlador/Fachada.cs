﻿using EntityFramework.Services;
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
        private readonly IBannerRepository iBannerRepository;
        private readonly ICampaniaRepository iCampaniaRepository;
        private readonly IRepository<Fuente> iFuenteRepository;
        private readonly IRepository<Imagen> iImagenRepository;

        /// <summary>
        /// Constructor de la clase Fachada que basicamente inyecta las dependencias de los repositorios con Ninject.
        /// </summary>
        /// <param name="bannerRepository"></param>
        /// <param name="campaniaRepository"></param>
        public Fachada(IBannerRepository bannerRepository, ICampaniaRepository campaniaRepository, IRepository<Fuente> fuenteRepository, IRepository<Imagen> imagenRepository)
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
        public void AddBannerRSS(string pNombre, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin, int pCodigo, string pValor, Fuente pFuente)
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

        public void AddFuente(Fuente pFuente)
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

        public void AddImagen(string pNombre, byte pHash, Campania pCampania)
        {
            Imagen imagen = new Imagen();
            //imagen.Id
            imagen.Estado = true;
            imagen.Nombre = pNombre;
            imagen.Hash = pHash;
            try
            {
                iImagenRepository.Insert(imagen);
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
                iBannerRepository.Delete(pBanner);
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
                iBannerRepository.Delete(pBanner);
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
                iFuenteRepository.Delete(pFuente);
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
                iCampaniaRepository.Delete(pCampania);
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
                iImagenRepository.Delete(pImagen);
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
                iBannerRepository.DeleteById(pId);
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
                iBannerRepository.DeleteById(pId);
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
                iFuenteRepository.DeleteById(pId);
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
                iCampaniaRepository.DeleteById(pId);
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
        public void updateBannerRSS (BannerRSS pBanner)
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

        public void updateBannerTXT (BannerTextoFijo pBanner)
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

        public void updateFuente (Fuente pFuente)
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

        public void updateCampania (Campania pCampania)
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

        public void updateImagen (Imagen pImagen)
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
        ///     getByIdBanner
        ///     getByIdFuente
        ///     getByIdCampania
        ///     getByIdImagen
        /// </summary>
        public Banner getByIdBanner (int pId)
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

        public Fuente getByIdFuente (int pId)
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

        public Campania getByIdCampania (int pId)
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

        public Imagen getByIdImagen (int pId)
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
                return iBannerRepository.GetAll();
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
                return iFuenteRepository.GetAll();
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
                return iCampaniaRepository.GetAll();
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

        public IQueryable<Fuente> GetFuente(Expression<Func<Fuente, bool>> predicate)
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
