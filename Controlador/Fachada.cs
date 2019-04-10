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
        
    }
}
