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

namespace Vista
{
    public class InjectModule : NinjectModule
    {

        public override void Load()
        {
            //Bindeamos las inyecciones de dependencias y las hacemos Singleton , es decir, una sola instancia de las variables para toda la ejecucion del programa.
            Bind<IBannerRepository>().To<BannerRepository>().InSingletonScope();
            Bind<ICampaniaRepository>().To<CampaniaRepository>().InSingletonScope();
            Bind<IRepository<Campania>>().To<RepositoryBase<Campania>>().InSingletonScope();
            Bind<FuenteRepository>().ToSelf().InSingletonScope();
            Bind<ImagenRepository>().ToSelf().InSingletonScope();
            Bind<Fachada>().ToSelf().InSingletonScope();
            Bind<Vista.Logger.ILogger>().To<Logger4net>().InSingletonScope();

        }
    }
}
