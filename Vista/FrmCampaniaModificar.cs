using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Core.Models;

namespace Vista
{
    public partial class FrmCampaniaModificar : Form
    {
        private readonly Fachada iFachada;
        private readonly Logger.ILogger iLogger;

        public FrmCampaniaModificar(Fachada fachada, Logger.ILogger logger)
        {
            iFachada = fachada;
            iLogger = logger;
            InitializeComponent();
        }

        private void FrmModificarCampania_Load(object sender, EventArgs e)
        {
            IList<string> mListaNombres = iFachada.GetAllNamesFromImages();
            foreach (string mNombre in mListaNombres)
            {
                dataGridViewTodasLasImagenes.Rows.Add(mNombre);
            }
            dataGridViewTodasLasImagenes.Show();
            if (dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value != null)
            {
                string mNombreImagen = dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value.ToString();
                Imagen mImagen = iFachada.GetImagenByName(mNombreImagen);
                pictureBoxVistaPreviaImagenes.Image = Utilidades.ByteToImage(mImagen.Hash);

            }
        }

        private void dataGridViewTodasLasImagenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value != null)
            {
                string mNombreImagen = dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value.ToString();
                Imagen mImagen = iFachada.GetImagenByName(mNombreImagen);
                pictureBoxVistaPreviaImagenes.Image = Utilidades.ByteToImage(mImagen.Hash);
            }
        }

        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
            if (dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value != null)
            {
                string mNombreImagen = dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value.ToString();

                dataGridViewImagenesSeleccionadas.Rows.Add(mNombreImagen);
                dataGridViewImagenesSeleccionadas.Show();

                dataGridViewTodasLasImagenes.Rows.Remove(dataGridViewTodasLasImagenes.CurrentRow);
                dataGridViewTodasLasImagenes.Show();
            }
        }

        private void buttonQuitarImagen_Click(object sender, EventArgs e)
        {
            if (dataGridViewImagenesSeleccionadas.CurrentRow.Cells[0].Value != null)
            {
                string mNombreImagen = dataGridViewImagenesSeleccionadas.CurrentRow.Cells[0].Value.ToString();

                dataGridViewTodasLasImagenes.Rows.Add(mNombreImagen);
                dataGridViewTodasLasImagenes.Show();

                dataGridViewImagenesSeleccionadas.Rows.Remove(dataGridViewImagenesSeleccionadas.CurrentRow);
                dataGridViewImagenesSeleccionadas.Show();
            }
        }

        private void dataGridViewImagenesSeleccionadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewImagenesSeleccionadas.CurrentRow.Cells[0].Value != null)
            {
                string mNombreImagen = dataGridViewImagenesSeleccionadas.CurrentRow.Cells[0].Value.ToString();
                Imagen mImagen = iFachada.GetImagenByName(mNombreImagen);
                pictureBoxImagenesActuales.Image = Utilidades.ByteToImage(mImagen.Hash);
            }
        }

        private void btnCancelarCambios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConsultarDisponibilidad_Click(object sender, EventArgs e)
        {

        }
    }
}
