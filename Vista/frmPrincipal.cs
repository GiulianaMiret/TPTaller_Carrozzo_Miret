using Controlador;
using Core.Models;
using EntityFramework.Services;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Vista
{
    /// <summary>
    ///  Clase principal de la aplicación
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        /// <summary>
        /// Variables que se injectaran mediante Ninject en el constructor.
        /// </summary>
        private readonly Fachada cFachada;
        private readonly Vista.Logger.ILogger cLogger;

        public FrmPrincipal(Fachada pFachada, Logger.ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            InitializeComponent();
        }
        
        private void agregarFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmFuenteRSSTXTAgregar>().ShowDialog();
        }

        private void gestiónDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmImagenesGestion>().ShowDialog();
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmOperacion>().ShowDialog();
        }

        private void gestiónDeCampañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmCampaniaAgregar>().ShowDialog();
        }

        private void modificarCampañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmCampaniaModificar>().ShowDialog();
        }

        private void eliminarFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmFuenteRSSTXTBorrar>().ShowDialog();
        }

        private void borrarCampañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmCampaniaBorrar>().ShowDialog();
        }

        private void modificarFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmFuenteRSSTXTModificar>().ShowDialog();
        }

        private void agregarBannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmBannerAgregar>().ShowDialog();
        }

        private void borrarBannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmBannerBorrar>().ShowDialog();
        }

        private void modificarBannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmBannerModificar>().ShowDialog();
        }

        /// <summary>
        /// Actualiza todas las fuentes RSS si hay conexión a internet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void actualizarFuentesRSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cLogger.Debug("Actualizando las fuentes RSS..");
            try
            {
                var AllRSS = cFachada.GetAllRSS();
                foreach (var mRSS in AllRSS)
                {
                    cLogger.Debug("Actualizando la fuente con id " + mRSS.Id);
                    mRSS.Actualizar();
                }
                MessageBox.Show("Fuentes actualizadas con éxito.");
            }
            catch (Exception x)
            {
                cLogger.Debug(x.ToString());
                MessageBox.Show("Hubo un error, por favor consulte su administrador (ver log)");
            }
            
        }
    }
}
