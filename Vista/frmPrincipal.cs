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

namespace Vista
{
    public partial class FrmPrincipal : Form
    {
        private readonly Fachada iFachada;
        private readonly IBannerRepository iBannerRepository;
        private readonly Vista.Logger.ILogger iLog;
        public FrmPrincipal(Fachada fachada, Logger.ILogger log)
        {
            iFachada = fachada;
            iLog = log;
            InitializeComponent();
        }
        
        private void agregarFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmAgregarFuenteRSSTXT>().ShowDialog();
        }

        private void gestiónDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmGestionImagenes>().ShowDialog();
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmOperacion>().ShowDialog();
        }

        private void gestiónDeCampañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmAgregarCampania>().ShowDialog();
        }

        private void modificarCampañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmModificarCampania>().ShowDialog();
        }
    }
}
