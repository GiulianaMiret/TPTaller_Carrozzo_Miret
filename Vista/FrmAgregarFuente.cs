//using Core.Models;
using Controlador;
using Core.Models;
using EntityFramework.Services;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAgregarFuente : Form
    {
        private readonly Fachada iFachada;
        public FrmAgregarFuente(Fachada fachada)
        {
            iFachada = fachada;
            InitializeComponent();
        }

        private void btnFuenteGuardar_Click(object sender, EventArgs e)
        {
            FuenteRSS mFuente = new FuenteRSS();
            mFuente.Descripcion = textBoxDescripfuente.Text;
       //     mFuente.URL = textBoxURLfuente;
            mFuente.Estado = true;
            iFachada.AddFuente(mFuente);
        }
    }
}
