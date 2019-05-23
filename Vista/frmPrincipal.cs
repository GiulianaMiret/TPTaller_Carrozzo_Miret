using Controlador;
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
        public FrmPrincipal(IBannerRepository bannerRepository, Fachada fachada, Logger.ILogger log)
        {
            iBannerRepository = bannerRepository;
            iFachada = fachada;
            iLog = log;
            InitializeComponent();
        }
        
        private void agregarFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iLog.Info("PRUEBA!");
        }
    }
}
