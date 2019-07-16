﻿using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    public class CompositionRoot
    {
        private static IKernel cNinjectKernel;

        public static void Wire(INinjectModule pModule)
        {
            cNinjectKernel = new StandardKernel(pModule);
        }

        public static T Resolve<T>()
        {
            return cNinjectKernel.Get<T>();
        }
    }
}
