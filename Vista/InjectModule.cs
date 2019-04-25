using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using EntityFramework.Services;
using Core.Models;

namespace Vista
{
    public class InjectModule : NinjectModule
    {      
        public override void Load()
        {
            //Bindeamos las inyecciones de dependencias y las hacemos Singleton , es decir, una sola instancia de las variables para toda la ejecucion del programa.
            Bind<IRepository<Banner>>().To<BannerRepository>().InSingletonScope();
            Bind<IRepository<Campania>>().To<CampaniaRepository>().InSingletonScope();
            Bind<IRepository<Fuente>>().To<FuenteRepository>().InSingletonScope();
            Bind<IRepository<Imagen>>().To<ImagenRepository>().InSingletonScope();
        }
    }
}
