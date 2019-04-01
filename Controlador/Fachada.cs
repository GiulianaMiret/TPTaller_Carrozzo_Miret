using Controlador.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private readonly ICampaniaRepository _campaniaRepository;

        /// <summary>
        /// Constructor de la clase Fachada que basicamente inyecta las dependencias de los repositorios con Ninject.
        /// </summary>
        /// <param name="bannerRepository"></param>
        /// <param name="campaniaRepository"></param>
        public Fachada(IBannerRepository bannerRepository, ICampaniaRepository campaniaRepository)
        {
            _bannerRepository = bannerRepository;
            _campaniaRepository = campaniaRepository;
        }
        
    }
}
