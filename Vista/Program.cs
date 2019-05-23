using Controlador;
using log4net;
using Ninject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        ///         

        [STAThread]
        static void Main()
        {
            //DI Injection , Ninject + Log4Net
            CompositionRoot.Wire(new InjectModule());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(CompositionRoot.Resolve<FrmPrincipal>());

        }
    }
}
