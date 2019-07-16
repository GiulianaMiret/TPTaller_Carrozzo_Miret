using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Models;
using Controlador;

namespace Vista
{
    public partial class FrmCampaniaBorrar : Form
    {
        private readonly Fachada iFachada;
        private readonly Logger.ILogger iLogger;


        public FrmCampaniaBorrar(Fachada fachada, Logger.ILogger logger)
        {
            iFachada = fachada;
            iLogger = logger;
            InitializeComponent();
        }


        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Campania> mListaResultadoBusqueda = new List<Campania>();
            if (textBoxNombreCampania.Text != "")
            {
                mListaResultadoBusqueda = iFachada.FilterCampania(x => x.Nombre == textBoxNombreCampania.Text).ToList();
            }
            


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Guarda todas las campañas seleccionadas 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
