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
        private readonly Fachada cFachada;
        private readonly Logger.ILogger cLogger;


        public FrmCampaniaBorrar(Fachada fachada, Logger.ILogger logger)
        {
            cFachada = fachada;
            cLogger = logger;
            InitializeComponent();
        }

        private void FrmCampaniaBorrar_Load(object sender, EventArgs e)
        {
            dataGridViewCampanias.DataSource = cFachada.GetAllCampania();
        }
              
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Campania> mListaResultadoBusqueda = new List<Campania>();
            if (textBoxNombreCampania.Text != "")
            {
                mListaResultadoBusqueda = cFachada.GetAllCampania().Where(x => x.Nombre.ToLower().Contains(textBoxNombreCampania.Text.ToLower())).ToList();
                dataGridViewCampanias.DataSource = mListaResultadoBusqueda;
            }
            else
            {
                mListaResultadoBusqueda = cFachada.GetAllCampania();
            }
            dataGridViewCampanias.DataSource = mListaResultadoBusqueda;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCampanias.CurrentRow.Index != -1)
                {
                    Campania mCampania = new Campania { Id = Convert.ToInt32(dataGridViewCampanias["Id", dataGridViewCampanias.CurrentRow.Index].Value) };
                    cFachada.DeleteCampania(mCampania);
                    dataGridViewCampanias.DataSource = cFachada.GetAllCampania();
                    MessageBox.Show("La campaña se ha borrado exitosamente");
                }
            }
            catch (Exception mException)
            {
                cLogger.Debug(mException.Message);
                MessageBox.Show("Ocurrio un error: " + mException.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
