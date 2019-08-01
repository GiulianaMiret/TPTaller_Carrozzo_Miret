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
    public partial class FrmPrincipal : Form
    {
        private readonly Fachada iFachada;
        private readonly Vista.Logger.ILogger iLog;

        public FrmPrincipal(Fachada fachada, Logger.ILogger log)
        {
            iFachada = fachada;
            iLog = log;

            //Creo un hilo
            //Thread mHilo = new Thread(new ThreadStart(SplashStart));
           // mHilo.Start();
            //ponemos a dormir FrmPrincipal
            // Thread.Sleep(5000);
            this.SplashStart();
            InitializeComponent();
           // mHilo.Abort();
        }
        
        public void SplashStart()
        {
            Application.Run(CompositionRoot.Resolve<SplashScreen>());
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
    }
}
