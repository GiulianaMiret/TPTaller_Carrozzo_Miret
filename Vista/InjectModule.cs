using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using EntityFramework.Services;
using Core.Models;
using EntityFramework;

namespace Vista
{
    public class InjectModule : NinjectModule
    {      
        public override void Load()
        {
            //Bindeamos las inyecciones de dependencias y las hacemos Singleton , es decir, una sola instancia de las variables para toda la ejecucion del programa.
            Bind<IBannerRepository>().To<BannerRepository>().InSingletonScope();
            Bind<ICampaniaRepository>().To<CampaniaRepository>().InSingletonScope();
            Bind<FuenteRepository>().ToSelf().InSingletonScope();
            Bind<ImagenRepository>().ToSelf().InSingletonScope();
        }
    }
}
