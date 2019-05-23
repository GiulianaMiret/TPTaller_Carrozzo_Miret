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
        private readonly FuenteRepository iFuenteRepository;
        private readonly Fachada iFachada;
        public FrmAgregarFuente()
        {
            
            InitializeComponent();
        }

        private void btnFuenteGuardar_Click(object sender, EventArgs e)
        {
            Fuente mFuente = new Fuente();
            mFuente.Descripcion = textBoxDescripfuente.Text;
            mFuente.URL = textBoxURLfuente.Text;
            mFuente.Estado = true;
            iFachada.AddFuente(mFuente);
        }
    }
}
