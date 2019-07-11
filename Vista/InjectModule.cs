using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using EntityFramework.Services;
using EntityFramework;
using Controlador;
using Core.Models;
using log4net;
using log4net.Core;
using Vista.Logger;
using Vista.EntityFramework.Services;
using System.Data.Entity;
using Vista.Core.Models;

namespace Vista
{
    public class InjectModule : NinjectModule
    {

        public override void Load()
        {
            //Bindeamos las inyecciones de dependencias y las hacemos Singleton , es decir, una sola instancia de las variables para toda la ejecucion del programa.
            Bind<IBannerRepository>().To<BannerRepository>().InSingletonScope();
            Bind<ICampaniaRepository>().To<CampaniaRepository>().InSingletonScope();
            Bind<IFuenteRepository>().To<FuenteRepository>().InSingletonScope();
            Bind<IImagenRepository>().To<ImagenRepository>().InSingletonScope();
            Bind<IRepository<Campania>>().To<RepositoryBase<Campania>>().InSingletonScope();
            Bind<IRepository<FuenteRSS>>().To<RepositoryBase<FuenteRSS>>().InSingletonScope();
            Bind<IRepository<FuenteTextoFijo>>().To<RepositoryBase<FuenteTextoFijo>>().InSingletonScope();
            Bind<IRepository<Banner>>().To<RepositoryBase<Banner>>().InSingletonScope();
            Bind<IRepository<Imagen>>().To<RepositoryBase<Imagen>>().InSingletonScope();
            Bind<Fachada>().ToSelf().InSingletonScope();
            Bind<DigitalBillboardContext>().To<DigitalBillboardContext>().InSingletonScope();
            Bind<Vista.Logger.ILogger>().To<Logger4net>().InSingletonScope();

        }
    }
}
